'use strict';

var actionUtil =
{
    appendData: function (divId, actionUrl, parameters, onSuccess, onError) {
        var successMethod = function (data) {
            $("#" + divId).append(data);
        };

        var errorMethod = function (error) {
            notification.notifyErrorMessage(error);
        };

        if (onSuccess != null)
            successMethod = onSuccess;

        if (onError != null)
            errorMethod = onError;

        $.get(actionUrl, parameters, successMethod).fail(errorMethod);
    },
    getData: function (divId, actionUrl, parameters, onSuccess, onError) {

        var successMethod = function (data) {
            $("#" + divId).html(data);
        };

        var errorMethod = function (error) {
            notification.notifyErrorMessage(error);
        };

        if (onSuccess != null)
            successMethod = onSuccess;

        if (onError != null)
            errorMethod = onError;

        $.get(actionUrl, parameters, successMethod).fail(errorMethod);
    },
    getData: function (divId, actionUrl, parameters, onSuccess, onError, loaderObject) {

        var successMethod = function (data) {
            $("#" + divId).html(data);
            loader.load(false, loaderObject);
        };

        var errorMethod = function (error) {
            // showErrorMessage
            notification.notifyErrorMessage(error.statusText);
            loader.load(false, loaderObject);
        };

        if (onSuccess != null)
            successMethod = onSuccess;

        if (onError != null)
            errorMethod = onError;

        $.get(actionUrl, parameters, successMethod).fail(errorMethod);
    },

    failure: function(error) {
        console.log(error);
        notification.notifyErrorMessage(error.responseText);
    },

    removeData: function (actionUrl, parameters, message, onSuccess, dataGridId) {
        loader.load(true);

        var successMethod = function (data) {
            dataGrid.reload(dataGridId);
            notification.notifySuccessMessage();
            loader.load(false);
        };

        var errorMethod = function (error) {
            notification.notifyErrorMessage(error.statusText);
            loader.load(false);
        };

        var dialogConfirmMethod = function () {
            $.get(actionUrl, parameters, successMethod).fail(errorMethod);
        };

        var dialogCancelMethod = function () {
            loader.load(false);
        };

        if (onSuccess != null) {
            successMethod = onSuccess;
        }

        dialog.confirm(notification.warningTitle, message, dialogConfirmMethod, dialogCancelMethod);
    }
}


$(document).ajaxError(function (a, error) {

    loader.load(false);

    alert('s');

    if (typeof error.responseJSON === 'undefined') {

        if ($(".error-div").length > 0)
            $(".error-div").html("<br /><div class=\"alert alert-danger\">" + error.statusText + "</div>");
        else
            notification.notifyErrorMessage(error.statusText);
    }
    else {
        var messages = error.responseJSON;

        var errorText = "";

        for (var i = 0; i < messages.length; i++)
            errorText += messages[i] + "\n";

        if ($(".error-div").length > 0)
            $(".error-div").html("<br /><div class=\"alert alert-danger\">" + errorText + "</div>");
        else
            notification.notifyErrorMessage(errorText);
    }
});