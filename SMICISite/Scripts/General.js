//var VDir = "/NombreCarpetaDelSitio";  // CUando está publicado
var VDir = ""; // Cuando es Desarrollo
var url = window.window.location.href;
var arr = url.split("/");
var RootURL = arr[0] + "//" + arr[2] + VDir + "/";

$(document).ready(function () {

   //llamados de eventos

    //Formatea Tablas
    FormatearTablas();

});

/******************** INICIO SCRIPTS PARA ALMACENAR Y ACTUALIZAR DATOS *******************/
/*****************************************************************************************/
function Login() {
    var _email = $("#strEmail").val();
    var _pass = $("#strPass").val();

    var Param = {
        strEmail: _email,
        strPass: _pass
    };

    //MostrarSpin(true);

    $.ajax({
        url: RootURL + "Home/Login",
        type: "get",
        cache: false,
        data: Param,
        success: function (response) {
            GritterPop(response);
            //MostrarSpin(false);
        },
        error: function (response) {
            MostrarSpin(false);
            ManejaErroresAJAXSession(response);
        }
    });
}
function Login2() {

    var _form = $('#ajaxFormLogin');

    if (ValidarCamposRequeridos(_form)) {
        $.spin('true');
        var options = {
            success: function (data) {
                $.spin('false');

                GritterPop(data);
                window.location.href = RootURL + 'Ciudadano/Index';
            },
            error: function (response) {
                $.spin('false');
                ManejaErroresAJAXSession(response);
                window.location.href = RootURL + 'Ciudadano/Index';
            }
        }
        $('#ajaxFormLogin').ajaxSubmit(options);
    }
}
function Registro() 
{
    var _email = $("#strEmail").val();
    var _pass = $("#strPass").val();

    var Param = {
        strEmail: _email,
        strPass: _pass
    };

    //MostrarSpin(true);

    $.ajax({
        url: RootURL + "Home/Registro",
        type: "get",
        cache: false,
        data: Param,
        success: function (response) {
            GritterPop(response);
            //MostrarSpin(false);
        },
        error: function (response) {
            MostrarSpin(false);
            ManejaErroresAJAXSession(response);
        }
    });
}

// Cambiar Nombre según el formulario
// Crear métodos para guardar correspondientes al formulario
function SaveFormulario() {

    var _form = $('#ajaxNomFormulario');

    if (ValidarCamposRequeridos(_form)) {
        $.spin('true');
        var options = {
            success: function (data) {
                $.spin('false');
                if (!data.success) {
                    GritterPop(data);
                }
                else {
                    if (data.EsEdicion != true) {
                        MostrarPantallaInformacion(data.mensaje, data.titulo, function () {
                            $.spin('true');
                            window.location.href = RootURL + 'Controlador/ActionResult';
                        });
                    }
                    else {
                        GritterPop(data);
                    }
                }
            },
            error: function (response) {
                $.spin('false');
                ManejaErroresAJAXSession(response);
            }
        }
        $('#ajaxNomFormulario').ajaxSubmit(options);
    }
}

function BuscarParientes() {

    var _ced = $("#Cedula").val();
    var _nombre = $("#Nombre").val();
    var Param = {
        Cedula: _ced,
        Nombre: _nombre
    };
    MostrarSpin(true);
    $.ajax({
        url: RootURL + "Generales/BuscarParientes",
        type: "get",
        cache: false,
        data: Param,
        success: function (response) {
            //$.spin('false');
            $('#DivListaParientes').html(response);
            FormatearDataTablePuntual("dataTables-ListadoDeParentescos");
            MostrarSpin(false);
        },
        error: function (response) {
            MostrarSpin(false);
            ManejaErroresAJAXSession(response);
        }
    });
}

// Cambiar Nombre según el formulario
// Crear métodos para eliminar correspondientes al formulario
function EliminarPariente() {
    event.preventDefault();

    var IdEjePariente = arguments[0];
    var IdGeneral = arguments[1];
    var IdEjecutivo = arguments[2];

    var Param = {
        IdEjePariente: IdEjePariente,
        IdGeneral: IdGeneral,
        IdEjecutivo: IdEjecutivo
    };
    var opcionSi = function (response) {
        $.ajax({
            url: RootURL + "Generales/Delete?id=" + IdGeneral,
            type: "post",
            cache: true,
            data: Param,
            success: function (data) {
                MostrarPantallaInformacion(data.mensaje, data.titulo, function () {
                    $.spin('true');
                    window.location.href = RootURL + 'Ejecutivos/Details?IdEjecutivo=' + data.IdEjecutivo;
                });
            },
            error: function (response) {
                $.spin('false');
                ManejaErroresAJAXSession(response);
            }
        });
    };

    var opcionNo = function (response) { };

    MostrarPantallaConfirmacion("Realmene desea eliminar el XX", "Eliminar XX?", opcionSi, opcionNo, "Sí")

}

/******************** FIN SCRIPTS PARA ALMACENAR Y ACTUALIZAR DATOS **********************/
/*****************************************************************************************/



/*++++++++++++++++++++++++++++ INICIO FUNCIONES GENERALES ++++++++++++++++++++++++++++++++*/
/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

function MostrarSpin() {
    var Valor = arguments[0];
    $.spin(Valor);
};

/* Función para mostrar una pantalla de confirmación genérica que devuelve 2 callbacks dependiendo de la selección*/
function MostrarPantallaConfirmacion(textoMensaje, titulo, callBackSI, callBackNo, labelSi) {

    bootbox.dialog({
        message: textoMensaje,
        title: titulo,
        buttons: {
            success: {
                label: labelSi,
                className: "btn-success",
                callback: function () {
                    callBackSI();
                }
            },
            danger: {
                label: "No",
                className: "btn-danger",
                callback: function () {
                    callBackNo();
                }
            }
        }
    });
}

/* Función para mostrar una pantalla de información genérica con un botón de ok para salir de la pantalla...*/
function MostrarPantallaInformacion(textoMensaje, titulo, callback) {
    bootbox.dialog({
        message: textoMensaje,
        title: titulo,
        buttons: {
            danger: {
                label: "OK",
                className: "btn-default",
                callback: function () {
                    if (callback != null)
                        callback();
                }
            }
        }
    });
}

/* Función para validar los campos de un formulario por Ajax. Es necesario el script de jquery.form.js*/
function ValidarCamposRequeridos(_form) {
    $.validator.unobtrusive.parse(_form);
    _form.validate();
    if (_form.valid()) {
        return true;
    }
    else {
        var mensajeR = '<ul class="">';
        $.each(_form.validate().errorList, function (key, value) {
            mensajeR += '<li></i>' + value.message + '</li>';
        });
        mensajeR += "</ul>";

        MostrarPantallaInformacion(mensajeR, "Validaciones");
        return false;
    }
}

function EnviarMensajePantallaInformacion() {
    Mensaje = arguments[0];

    var mensajeR = '<ul class=""><li></i>' + Mensaje + '</li></ul>';
    MostrarPantallaInformacion(mensajeR, "Validaciones");
}

function ManejaErroresAJAXSession() {
    var respuesta = arguments[0];

    if (respuesta.status == 522) {
        MostrarPantallaInformacion("Su sesión ha expirado. Se está redirigieron automáticamente a la pantalla de Login para que ingrese nuevamente su contraseña.",
            "Validación Sesión", function () {
                window.location.href = RootURL + 'Login/Index';
            });
    }
    else
        MostrarPantallaInformacion(respuesta.responseText, "Error");
}

/* Función para mostrar mensaje de confirmación o de error...*/
function GritterPop(values) {
    $.gritter.add({
        // (string | mandatory) the heading of the notification
        title: values.titulo,
        // (string | mandatory) the text inside the notification
        text: values.mensaje,
        // (string | optional) the image to display on the left
        image: (values.success == true) ? RootURL + 'Content/AdminLTE/img/accepted_48.png' : (values.success == false) ? RootURL + 'Content/AdminLTE/img/cancel_48.png' : RootURL + 'Content/AdminLTE/img/warning_48.png',
        // (bool | optional) if you want it to fade out on its own or just sit there
        sticky: false,
        // (int | optional) the time you want it to be alive for before fading out
        time: '3000'
    });
}

function RefrescarDivX() {
    //$.spin('true');
    var nomController = arguments[0];
    var nomAction = arguments[1];
    var nomDiv = arguments[2];
    var Parametro1 = arguments[3];
    var Parametro2 = arguments[4];
    var NomTabla = arguments[5];


    var Param = {
        Parametro1: Parametro1,
        Parametro2: Parametro2,
    };

    $.ajax({
        url: RootURL + nomController + "/" + nomAction,
        type: "post",
        cache: false,
        data: Param,
        success: function (response) {
            //$.spin('false');
            $('#' + nomDiv).html(response);
            if (NomTabla != "0") {
                FormatearDataTablePuntual(NomTabla);
            }
        },
        error: function (response) {
            //$.spin('false');
            ManejaErroresAJAXSession(response);
        }
    });

    //$.spin('false');
}

/*Función para formatear tablas*/
function FormatearTablas() {

    $('table[id*=dataTables-]').DataTable({
        //"bDestroy": true,
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        },
        //"scrollX": true,
        //responsive: "true",
        lengthMenu: [[25, 50, -1], [25, 50, "All"]]
    });
}

function FormatearDataTablePuntual() {
    var datatable = arguments[0];

    $('#' + datatable).dataTable().fnDestroy();

    $('#' + datatable).DataTable({
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando del _START_ al _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando del 0 al 0 de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        },
        responsive: true,
        lengthMenu: [[5, 10, 25, 50, -1], [5, 10, 25, 50, "Todos"]]
    });
}

function CerrarModal() {
    var modalName = arguments[0];

    $('#' + modalName).modal('hide');
};

function AbrirModal(modalName) {
    $('#ModalParienteCreatePV').modal('show');
};

function CambiarTab() {
    var index = "#tab_" + $("#IdTab").val();

    //$("#TabsNum").tabs("option", "active", index);
    $('#TabsNum a[href="' + index + '"]').tab('show')
};
/*********************** FIN FUNCIONES GENERALES******************************************/
/*****************************************************************************************/