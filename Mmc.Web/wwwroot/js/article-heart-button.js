$(document).ready(function (){
   $('.article-heart').click(function (button) {
       let thisButton = $('.article-heart');
       thisButton.addClass("fa-solid");
       thisButton.removeClass("fa-regular");
   });
});
