// For disabling form submissions if there are invalid fields
(function () {
    'use strict';
    window.addEventListener('load', function () {

        // Fetch all the forms we want to apply the validation styles
        var forms = document.getElementsByClassName('needs-validation');
        
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();


  // FOR CREATE THE TABLE:
  // Variable para almacenar el ID incremental
var id = 0;

function addValues() {
    // Obtener los valores de los campos de texto
    var field1 = document.getElementById("validationCustom01").value;
    var field2 = document.getElementById("validationCustom02").value;
    var field3 = document.getElementById("validationCustom03").value;
    var field4 = document.getElementById("validationCustom04").value;
    var field5 = document.getElementById("validationCustom05").value;
    var field6 = document.getElementById("validationCustom06").value;
    // var field7 = document.getElementById("validationCustom07").value;
    // var field8 = document.getElementById("validationCustom08").value;

    // Añadir los valores y el ID a la tabla
    var table = document.getElementById("table");
    var row = table.insertRow(-1);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);
    var cell6 = row.insertCell(5);
    var cell7 = row.insertCell(6);
    // var cell8 = row.insertCell(7);
    // var cell9 = row.insertCell(7);
    var cell10 = row.insertCell(7);

    cell1.innerHTML = id;
    cell2.innerHTML = field1;
    cell3.innerHTML = field2;
    cell4.innerHTML = field3;
    cell5.innerHTML = field4;
    cell6.innerHTML = field5;
    cell7.innerHTML = field6;
    // cell8.innerHTML = field7;
    // cell9.innerHTML = field8;
    cell10.innerHTML = '<button type="button" onclick="deleteRow(this)">Delete</button>';

    // Incrementar el ID
    id++;
}

function deleteRow(button) {
    // Obtener la fila que contiene el botón presionado
    var row = button.parentNode.parentNode;

    // Eliminar la fila
    row.parentNode.removeChild(row);
}