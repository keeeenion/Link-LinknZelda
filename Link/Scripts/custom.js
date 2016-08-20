// Date picker
$(document).ready(function () {
    var date_input = $("#User_Birthdate");
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options={
        format: "dd/mm/yyyy",
        container: container,
        language: "et",
        orientation: "top"
    };
    date_input.datepicker(options);
})

// Datatable
$(document).ready(function () {
    $('#wb-top-10').dataTable();
});

var maxCount = 10;
var minimumCount = 5;

$("#loz-form").on('click', '#add-website', function () {
    if (parseInt($("#count").val()) < maxCount) {
        $("#count").val(parseInt($("#count").val()) + 1);
        $("form")[0].submit()
    } else {
        return;
    }
});

$("#loz-form").on('click', '#remove-website', function () {
    if (parseInt($("#count").val()) > minimumCount) {
        $("#count").val(parseInt($("#count").val()) - 1);
        $("form")[0].submit()
    } else {
        return;
    }
});

$("#loz-form").on('click', '#send-form', function () {
    $('#done').attr('checked', true);
    $("form")[0].submit();
});

$("#header").on('click', '#toggle-show', function () {
    $("#show-text").toggleClass("hidden");
    $("#show-visual").toggleClass("hidden");
});