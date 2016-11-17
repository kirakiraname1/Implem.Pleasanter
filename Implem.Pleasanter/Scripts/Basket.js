﻿$p.addBasket = function ($control, text, value) {
    $control.append($('<li/>')
        .attr('data-value', value !== undefined
            ? escape(value)
            : escape(text))
        .addClass('ui-widget-content ui-selectee')
        .append($('<span/>').text(text))
        .append($('<span/>')
            .addClass('ui-icon ui-icon-close button-delete-address')));
    $p.setData($control);
}