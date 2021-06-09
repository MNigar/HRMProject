$(function () {
    util.initialize();
});

$(document).ajaxError(function (a, error) {
    if (typeof error.responseJSON === 'undefined') {
        console.error(error);
    }
    else {
        var messages = error.responseJSON;
        console.error(messages);
        if ($(".error-div").length > 0) {
            $(".error-div").empty();
            $.each(messages, function (key, value) {
                $(".error-div").append("<br /><div class=\"alert alert-danger\">" + value + "</div>");
            });
        } else
            $.each(messages, function (key, value) {
                toastr.error(value);
            });
    }

    util.setLoader(false);
});