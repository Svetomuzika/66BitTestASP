"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/signalr/footballershub").build();
var inputs = document.getElementsByClassName("input");
var selects = document.getElementsByClassName("select");

connection.start();

connection.on("Send", function (id, data) {
    var counter = 0;

    for (var e = id * 5; e < (id * 5) + 5; e++) {
        inputs[e].value = data[counter];
        counter++;
    }

    selects[id].value = data[counter];
});
