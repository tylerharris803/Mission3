$("#button_submit").click(function () {
    var varassignment = $("#Assignments").val()
    var vargroupproject = $("#GroupProject").val()
    var varquizzes = $("#Quizzes").val()
    var varexams = $("#Exams").val()
    var varintex = $("#Intex").val()

    //check if one of the numbers are over 100 or below 0

    if (varassignment > 100 || varassignment < 0) {
        alert("Assignment percentage is not within the 0-100 range. Please change it before submitting.")
    } else if (vargroupproject > 100 || vargroupproject < 0) {
        alert("Group Project percentage is not within the 0-100 range. Please change it before submitting.")
    } else if (varquizzes > 100 || varquizzes < 0) {
        alert("Quizzes percentage is not within the 0-100 range. Please change it before submitting.")
    } else if (varexams > 100 || varexams < 0) {
        alert("Exams percentage is not within the 0-100 range. Please change it before submitting.")
    } else if (varintex > 100 || varintex < 0) {
        alert("Intex percentage is not within the 0-100 range. Please change it before submitting.")
    } else {

    }

    //Calculation of the final percent based on class weights

    var assignmentweight = varassignment * .55
    var groupprojectweight = vargroupproject * .05
    var quizzesweight = varquizzes * .10
    var examsweight = varexams * .20
    var intexweight = varintex * .10

    var finalpercent = assignmentweight + groupprojectweight + quizzesweight + examsweight + intexweight

    var finalgrade = ""

    //check what letter grade should be given

    if (finalpercent >= 94) {
        finalgrade = "A"
    } else if (finalpercent >= 90) {
        finalgrade = "A-"
    } else if (finalpercent >= 87) {
        finalgrade = "B+"
    } else if (finalpercent >= 84) {
        finalgrade = "B"
    } else if (finalpercent >= 80) {
        finalgrade = "B-"
    } else if (finalpercent >= 77) {
        finalgrade = "C+"
    } else if (finalpercent >= 74) {
        finalgrade = "C"
    } else if (finalpercent >= 70) {
        finalgrade = "C"
    } else if (finalpercent >= 67) {
        finalgrade = "D+"
    } else if (finalpercent >= 64) {
        finalgrade = "D"
    } else if (finalpercent >= 60) {
        finalgrade = "D-"
    } else {
        finalgrade = "E"
    }

    alert("Grade Percentages: Assignments " + varassignment + "% -- " +
        "GroupProject " + vargroupproject + "% -- " +
        "Quizzes " + varquizzes + "% -- " +
        "Exams " + varexams + "% -- " +
        "Intex " + varintex + "% " + 
        "\n\n Final Grade Percentage: " + finalpercent + "%  "
        + "\n\n Final Grade Letter: " + finalgrade
    )
    
})


