$(document).ready(function (){
   $('.article-heart').click(function (button) {
       let thisButton = $('.article-heart');
       thisButton.addClass("fa-solid");
       thisButton.removeClass("fa-regular");
   }); 
});
function setArticleHeartListener(guid){
    $.ajax('@Url.Action("Delete","NoticeApi")', {
        type: 'POST',
        data: { guid: rowGuid },
        success: function (data, status, xhr) {
            Swal.fire(
                'Deleted!',
                'The row has been deleted.',
                'success'
            );
            $('#grid_data').bootgrid('reload');
        },
        error: function (jqXhr, textStatus, errorMessage) {
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: "Something went wrong! Contact your administration",
                footer: '@Html.ActionLink("See More Info","NoticeDelete","Documentation")'
            })
        }
    });
}