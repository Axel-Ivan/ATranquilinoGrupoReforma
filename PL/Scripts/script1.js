function noEmpty(id) {
    var valor = document.getElementById(id).value
    if (valor == "" || valor == null) {
        $("#"+id).css("border-color", "red");
        return false;
    }
    else {
        $("#"+id).css("border-color", "green");
        return true;
    }
}

function noSpaces(e, id) {
    var cadena = e.onkeyup.arguments[0].key
    if (!/[^a-zA-Z/]/.test(cadena)) {
        $("#" + id).css("border-color", "green");
        return true;
    }
    else {
        $("#"+id).css("border-color", "red");
        document.getElementById(id).value = ''
        return false;
    }
}

function edadCorrecta(e, id) {

    var numero = e.onkeyup.arguments[0].key;

    if (!/[^0-9]/.test(numero)) {
        var edad = document.getElementById(id).value

        if (edad > 10 && edad < 90) {
            $("#" + id).css("border-color", "green");
            return true;
        }
    }
    else {
        document.getElementById(id).value = ''
        $("#" + id).css("border-color", "red");
        return false;
    }
}