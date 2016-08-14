$(document).ready(function () {

    var navListItems = $('div.setup-panel div a'),
            allWells = $('.setup-content'),
            allNextBtn = $('.nextBtn'),
            allPrevBtn = $('.prevBtn');

    allWells.hide();

    navListItems.click(function (e) {
        e.preventDefault();
        var $target = $($(this).attr('href')),
                $item = $(this);

        if (!$item.hasClass('disabled')) {
            navListItems.removeClass('btn-primary').addClass('btn-default');
            $item.addClass('btn-primary');
            allWells.hide();
            $target.show();
            $target.find('input:eq(0)').focus();
        }
    });

    allNextBtn.click(function () {
        var curStep = $(this).closest(".setup-content"),
            curStepBtn = curStep.attr("id"),
            nextStepWizard = $('div.setup-panel div a[href="#' + curStepBtn + '"]').parent().next().children("a"),
            curInputs = curStep.find("input[type='text'],input[type='url']"),
            isValid = true;

        $(".form-group").removeClass("has-error");
        for (var i = 0; i < curInputs.length; i++) {
            if (!curInputs[i].validity.valid) {
                isValid = false;
                $(curInputs[i]).closest(".form-group").addClass("has-error");
            }
        }

        if (isValid)
            nextStepWizard.removeAttr('disabled').trigger('click');
    });

    allPrevBtn.click(function () {
        var curStep = $(this).closest(".setup-content"),
            curStepBtn = curStep.attr("id"),
            prevStepWizard = $('div.setup-panel div a[href="#' + curStepBtn + '"]').parent().prev().children("a");

        $(".form-group").removeClass("has-error");
        prevStepWizard.removeAttr('disabled').trigger('click');
    });

    $('div.setup-panel div a.btn-primary').trigger('click');
});

var _pages = 1;
var maxPages = 10;
var minPages = 1;

var template = $('#sections .webform:first').clone();

$("#web-add").on("click", function () {
    if ($("#web-add").hasClass('disabled')) { return; }
    if (_pages + 1 > maxPages) { $("#web-add").addClass("disabled"); return; }

    _pages++;
    if (_pages > minPages) { $("#web-subtract").removeClass("disabled"); }
    var section = template.clone().find(':input').each(function () {
        var newId = $(this).id + _pages;
        $(this).id = newId;
    }).end()
    .appendTo('#sections');
});

// Webforms
$("#web-subtract").on("click", function () {
    if ($("#web-subtract").hasClass('disabled')) { return; }
    if (_pages - 1 < minPages) { $("#web-subtract").addClass("disabled"); return; }

    _pages--;
    if (_pages < minPages) { $("#web-add").removeClass("disabled"); }
    $('#sections .webform:last').fadeOut(90, function () {
        $('#sections .webform:last').remove();
        return false;
    });
});

// Slider
$(document).ready(function () {
    var date_input = $('input[name="date"]');
    var options = {
        format: "dd/mm/yyyy",
        language: "et"
    };
    date_input.datepicker(options);
})