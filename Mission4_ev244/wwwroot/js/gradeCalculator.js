// This assigns each grade category to a variable and calculates a person's grade based on their percentages of each grade category.
// Prints final percentage as well as their Letter Grade
$("#submit").click(() => {
    var assignments = $("#assignments").val() * 50;
    var projects = $("#projects").val() * 10;
    var quizzes = $("#quizzes").val() * 10;
    var midterm = $("#midterm").val() * 10;
    var final = $("#final").val() * 10;
    var intex = $("#intex").val() * 10;

    var total = assignments + projects + quizzes + midterm + final + intex
    var grade = Math.round(total / 100);

    let letterGrade = "";
    if (grade >= 94) letterGrade = "A";
    else if (grade < 94 && grade >= 90) letterGrade = "A-";
    else if (grade < 90 && grade >= 87) letterGrade = "B+";
    else if (grade < 87 && grade >= 84) letterGrade = "B";
    else if (grade < 84 && grade >= 80) letterGrade = "B-";
    else if (grade < 80 && grade >= 77) letterGrade = "C+";
    else if (grade < 77 && grade >= 74) letterGrade = "C";
    else if (grade < 74 && grade >= 70) letterGrade = "C-";
    else if (grade < 70 && grade >= 67) letterGrade = "D+";
    else if (grade < 67 && grade >= 64) letterGrade = "D";
    else if (grade < 64 && grade >= 60) letterGrade = "D-";
    else letterGrade = "E";
    const results = letterGrade + " , " + grade + "%";
    /*$("#grade").text(results)*/
    alert(results)

});