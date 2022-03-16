$(document).ready(function () {
    $("#pictureModal").on("show.bs.modal", function (e) {
        var image = $(e.relatedTarget).attr("src");
        $("#imagepreview").attr("src", image);
        var dataText = $(e.relatedTarget).attr("data-text");
        //var recipient = image1.data('whatever'); // Extract info from data-* attributes
        var modal = $(this);
        modal.find(".modal-title").text("Picture of " + dataText);
        //modal.find('.modal-body img').val(recipient);
        //$(this).find('h5#modal-title').text('title'));
    });
});
/**/
