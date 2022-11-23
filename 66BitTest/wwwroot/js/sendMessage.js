"use strict";

var submits = document.getElementsByClassName("editContent");
var inputs = document.getElementsByClassName("input");
var selects = document.getElementsByClassName("select");

for (let i in submits) {
    submits[i].addEventListener('click', function (event) {
        if (submits[i].value == "Редактировать") {

            const id = Number(i);
            var data = [];

            for (var e = i * 5; e < (i * 5) + 5; e++)
                data.push(inputs[e].value);

            data.push(selects[id].value);

            connection.invoke("Send", id, data);
        }
    });
}