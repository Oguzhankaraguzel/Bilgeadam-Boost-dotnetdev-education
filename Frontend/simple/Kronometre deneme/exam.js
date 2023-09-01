window.addEventListener('DOMContentLoaded', function () {
    var questions = document.getElementsByClassName('question');
    if (questions.length > 0) {
        questions[0].style.display = 'block';
    }
});

function previousQuestion() {
    var questions = document.getElementsByClassName('question');
    var currentQuestion = getCurrentQuestionIndex();

    if (currentQuestion > 0) {
        questions[currentQuestion].style.display = 'none';
        questions[currentQuestion - 1].style.display = 'block';
    }
}

function nextQuestion() {
    var questions = document.getElementsByClassName('question');
    var currentQuestion = getCurrentQuestionIndex();

    if (currentQuestion < questions.length - 1) {
        questions[currentQuestion].style.display = 'none';
        questions[currentQuestion + 1].style.display = 'block';
    }
}

function getCurrentQuestionIndex() {
    var questions = document.getElementsByClassName('question');

    for (var i = 0; i < questions.length; i++) {
        if (questions[i].style.display === 'block') {
            return i;
        }
    }

    return -1;
}

function goToQuestion() {
    var questionNumber = parseInt(document.getElementById('soruNumarasi').value);
    var questions = document.getElementsByClassName('question');

    for (var i = 0; i < questions.length; i++) {
        questions[i].style.display = 'none';
    }

    if (questionNumber >= 1 && questionNumber <= questions.length) {
        questions[questionNumber - 1].style.display = 'block';
    } else {
        alert("Geçersiz soru numarası!");
    }
}

function confirmFinishExam(examStudentId) {
    Swal.fire({
        title: 'Sınavı bitirmek istediğinize emin misiniz?',
        text: "Bitirdikten sonra bir daha bu sınava giremezsiniz",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Evet, bitir!',
        cancelButtonText: 'İptal'
    }).then((result) => {
        if (result.isConfirmed) {
            sendAnswers(examStudentId);
        }
    });
}

function sendAnswers(examStudentId) {
    var questions = document.getElementsByClassName('question');
    var formData = new FormData();

    for (var i = 0; i < questions.length; i++) {
        var question = questions[i];
        var questionId = question.id;
        var selectedAnswers = [];
        

        var radioButtons = question.querySelectorAll('input[type="radio"][name="cevap"]:checked');
        var checkboxes = question.querySelectorAll('input[type="checkbox"][name="cevap"]:checked');
        var textarea = question.querySelector('textarea');
        var fileInput = question.querySelector('input[type="file"]');


        // Like radio buttonları yakalama.
        var likeRadio = question.querySelector('input[type="checkbox"][name="like"]:checked');

        for (var j = 0; j < radioButtons.length; j++) {
            selectedAnswers.push(radioButtons[j].value);
        }

        for (var k = 0; k < checkboxes.length; k++) {
            selectedAnswers.push(checkboxes[k].value);
        }

        if (textarea) {
            var textareaValue = textarea.value.replace(/\r?\n/g, '');
            selectedAnswers.push(textarea.value);
        }

        if (likeRadio == null)
            var likeDislike = null;
        else
            var likeDislike = true;

        formData.append('answers[' + i + '].questionId', questionId);
        formData.append('answers[' + i + '].examStudentId', examStudentId);
        formData.append('answers[' + i + '].LikeDislikeStatus', likeDislike);
        for (var l = 0; l < selectedAnswers.length; l++) {
            formData.append('answers[' + i + '].answers', selectedAnswers[l]);
        }
        if (fileInput && fileInput.files.length > 0) {
            var file = fileInput.files[0];
            formData.append('answers[' + i + '].fileAnswer', file, file.name);
        }
    }

    $.ajax({
        url: "/Student/Exam/StudentQuestionAnswers",
        type: "POST",
        data: formData,
        processData: false,
        contentType: false,
        success: function () {
            window.location.href = "/Student/Exam/GetCurrentExamsList"
        }
    });
}


