
function buy(a) {
    var name = $(a).attr('data-name')
    var newClass = {
        "disabled": "disabled",
        "value": "Bought",
        "class" : "btn btn-info btn-block"
    };
    if (!confirm("Buy \"" + name + "\"?")) { return; }

    $(a).attr(newClass);

}