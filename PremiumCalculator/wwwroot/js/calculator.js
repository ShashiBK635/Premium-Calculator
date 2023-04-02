// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var txtDOB = $('#txtDOB');
    var ddlOccupation = $('#ddlOccupation');
    var frmUpdateParty = $('#frmUpdateParty');
    txtDOB.datepicker({
        format: "dd-mm-yyyy",
        startView: 2,
        maxViewMode: 2,
        autoclose: true,
        endDate: "0d",
        startDate: "-70Y"
    });

    ddlOccupation.change(function () {
        //console.log("occupation changed: " + ddlOccupation.val());
        frmUpdateParty.submit();
    });
});