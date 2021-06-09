'use strict';

var util = {
    initialize: function () {
        $('[data-toggle="tooltip"]').tooltip();
        $("input").attr("autocomplete", "off");
    },

    setLoader: function (visible, target) {
        if (!target)
            target = ".loader-div";

        if (visible) {
            $(target).html(defaultContent.loading);
        } else {
            $(target).empty();
        }
    },

    success: function (message) {
        if (!message)
            message = ui.successMessage;

        toastr.success(message);
    },
    error: function (message) {
        if (!message)
            message = ui.errorMessage;

        toastr.error(message);
    },

    makeRequest: function (actionUrl, httpMethod, data, success) {
        var method = "GET";
        if (httpMethod) method = httpMethod;

        $.ajax(actionUrl, {
            data: data,
            httpMethod: method,
            success: function (response) {
                success(response);
            }
        });
    },

    showModal: function (target, actionUrl, httpMethod, data) {
        var method = "GET";
        if (httpMethod) method = httpMethod;

        $(target + " .modal-content").html(defaultContent.loading);
        $(target).modal({ backdrop: 'static', keyboard: false });

        $.ajax(actionUrl, {
            data: data,
            httpMethod: method,
            success: function (response) {
                $(target + " .modal-content").html(response);
                util.initialize();
                $.validator.unobtrusive.parse($(target));
            },
            error: function (error) {
                $(target + " .modal-content").html(defaultContent.error);
            }
        });
    },

    appendPartial: function (target, actionUrl, httpMethod, data) {
        var method = "GET";
        if (httpMethod) method = httpMethod;

        $(target).html(defaultContent.loading);

        $.ajax(actionUrl, {
            data: data,
            httpMethod: method,
            success: function (response) {
                $(target).html(response);
                util.initialize();
                $.validator.unobtrusive.parse($(target));
            },
            error: function (error) {
                $(target).html(defaultContent.error);
            }
        });
    },

    copyToClipboard: function (element) {
        var $temp = $("<input>");
        $("body").append($temp);
        $temp.val($(element).val()).select();
        document.execCommand("copy");
        $temp.remove();
    },
    remove: function (action, controller) {

        $.ajax(action, controller, {
            data: { id: selectedId },
            method: "POST",
            success: function (response) {
                dtGrid.reload();
            },
            error: function (error) {
                success(error);
            }
        });

    },

    getGrid: function (grids, id) {
         var i;
        for (i = 0; i < grids.length; i++) {
            if (grids[i].id == id) {
                var local_i = i;
                return grids[local_i];
            }
        }
        return null;
    },

};