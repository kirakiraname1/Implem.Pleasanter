﻿$p.currentIndex = function (array) {
    return array.indexOf($('#Id').val())
}

$p.switchTargets = function () {
    return $('#SwitchTargets').val().split(',')
}

$p.setCurrentIndex = function () {
    var array = $p.switchTargets();
    var index = $p.currentIndex(array);
    $('#CurrentIndex').text(index + 1 + '/' + array.length);
}