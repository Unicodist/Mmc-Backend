function fetchComments(url, guid, page){
    $.ajax({
        url: url,
        context: document.body,
        data : {guid:guid,page:page}
    }).done(function(data) {
        $('#comment-section-container').append(data);
    });
}
