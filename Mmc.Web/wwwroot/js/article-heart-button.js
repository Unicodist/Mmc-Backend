$(document).ready(function (){
   $('.article-heart').click(function (button) {
       let thisButton = $('.article-heart');
       thisButton.addClass("fa-solid");
       thisButton.removeClass("fa-regular");
   });
});
function setArticleHeartListener(guid,url){
    $(".article-heart-unliked").click(function () {
        $('.article-heart-unliked').toggleClass("article-heart-unliked","article-heart-liked")
        $.ajax(url, {
            type: 'POST',
            data: { guid: guid },
            success: function (data, status, xhr) {
                
            },
            error: function (jqXhr, textStatus, errorMessage) {

            }
        });
    });
}