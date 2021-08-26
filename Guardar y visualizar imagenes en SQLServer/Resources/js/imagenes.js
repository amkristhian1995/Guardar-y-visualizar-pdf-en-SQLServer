// Evento load
((document, window) => {
    //
})(document, window);
// Función Validar Formulario
var ValidarFormulario = () => {
    var file = document.querySelector("#fuImagen");
    if (file.files.length > 0) {
        return true;
    } else {
        alert("Debe de ingresar una imagen");
        return false;
    }
}