$(function () {
    var $txtDOB = $('#txtDOB');
    var $txtAge = $('#txtAge');
    var $ddlOccupation = $('#ddlOccupation');
    var $frmUpdateParty = $('#frmUpdateParty');

    $txtDOB.datepicker({
        format: "dd-M-yyyy",
        defaultDate: new Date(),
        startView: 2,
        maxViewMode: 2,
        autoclose: true,
        endDate: "0d",
        startDate: "-70Y"
    }).on("hide", function (e) {
        $txtAge.val(calculateAge($txtDOB.datepicker('getDate')));
        $txtAge.addClass('highlight');
        setTimeout(
            function () { $txtAge.removeClass('highlight'); },
            2000
        );
    });

    $ddlOccupation.change(function () {
        $frmUpdateParty.submit();
    });

    function calculateAge(dob) {
        if (dob === null) {
            return 0;
        }
        var today = new Date();
        var age = Math.floor((today - dob) / (365.25 * 24 * 60 * 60 * 1000));
        return age;
    }

});