$("#calculate").click(function () {
    alert("Grade Calculation: " +
        (($("#assignment").val() * .55) +
            ($("#project").val() * .05) +
            ($("#quizzes").val() * .10) +
            ($("#exam").val() * .20) +
            ($("#intex").val() * .10)));
    })