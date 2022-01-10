document.getElementById("calculate").addEventListener("click", (function () {
    alert("Grade Calculation: " +
        ((document.getElementById("assignment").value * .55) +
            (document.getElementById("project").value * .05) +
            (document.getElementById("quizzes").value * .10) +
            (document.getElementById("exam").value * .20) +
        (document.getElementById("intex").value * .10)));
    }))