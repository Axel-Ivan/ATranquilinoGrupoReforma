function required() {
    /*var empt = document.forms["frmDatos"]["txtNombre"].value;*/
    var empt = document.getElementById("txtNombre");
    if (empt == "" || empt == null) {
        /*alert("Please input a Value");*/
        $("#txtNombre").css("border-color", "red");
        return false;
    }
    else {
        /*alert('Code has accepted : you can try another');*/
        $("#txtNombre").css("border-color", "green");
        return true;
    }
}