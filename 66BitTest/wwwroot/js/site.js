var inputs = document.getElementsByClassName("input");
var selects = document.getElementsByClassName("select");
var submits = document.getElementsByClassName("editContent");

for (let i in submits) {
    submits[i].addEventListener('click', function (event) {
        if (submits[i].value == "Редактировать") {

            selects[i].style.background = "#575252";
            selects[i].style.color = "white";
            selects[i].onmousedown = () => true;

            for (var e = i * 6; e < (i * 6) + 6; e++) {
                inputs[e].readOnly = false;
                inputs[e].style.border = "1px solid grey";
            }
            submits[i].value = "Сохранить";
        }
        else {
            selects[i].style.background = "#464242";
            selects[i].style.color = "#b5b5b5";
            selects[i].onmousedown = () => false;

            for (var e = i * 6; e < (i * 6) + 6; e++) {
                inputs[e].readOnly = true;
                inputs[e].style.border = "0px";
            }
            submits[i].value = "Редактировать";
        }
    });
}
