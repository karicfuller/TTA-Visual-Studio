// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function firstColor() {
    document.getElementById("karis_site").style.color = "red";
}

function secondColor() {
    document.getElementById("karis_site").style.color = "purple";
}

var id = null;
function theMove() {
    var box = document.getElementById("theAnimation");
    var move = 0;
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame() {
        if (move == 350) {
            clearInterval(id);
        } else {
            move++;
            box.style.top = move + 'px';
            box.style.left = move + 'px';
        }
    }
}