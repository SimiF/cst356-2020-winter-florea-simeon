var students_data = '{"studentsData":[{"studentId":"2221243", "emailAddress":"b.morphew@lab.edu"},{"studentId":"2229612", "emailAddress":"d.shockley@lab.edu"},{"studentId":"2229183", "emailAddress":"c.hoch@lab.edu"},{"studentId":"2229463", "emailAddress":"l.pickerel@lab.edu"},{"studentId":"2226291", "emailAddress":"m.scouten@lab.edu"}]}'

function getData() {
    return JSON.parse(students_data);
}

function displayProducts(studentData) {
    var tableList = "";
    for (i = 0; i < studentData.length; i++) {
        var studentId = studentData[i].studentId;
        var emailAddress = studentData[i].emailAddress;
        tableList += "<tr><td>" + studentId + "</td><td>" + emailAddress + "</td></tr>";

        document.getElementById("student_data").innerHTML = tableList;
    }
}

function populateTable() {
    var data = getData();
    displayProducts(data.studentsData);
}

