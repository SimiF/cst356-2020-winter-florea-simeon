<template>
    <div>
        <head>
        <title>Student Information</title>
       
        <link rel="stylesheet" href='css/style.css'>
              
    </head>

    <body>   
        <h3 class="table_heading">Table 1: List of students.</h3>

        <table>  
            <thead>
                <tr>
                    <td>Student ID</td>
                    <td>Email Address</td>
                </tr>
            </thead>       
            <tbody id="student_data">

            </tbody>
        </table>
       
    </body>        
    </div>
</template>

<script>
export default {
    name: 'Students'
}
</script>

<style>
.table_heading {
    background-color: lightblue;
    text-transform: uppercase;
    border-left-color: blue; 
    border-left-style: solid;
    border-left-width: 15px;
    padding: 20px 20px 20px 20px;
}

#main_header {
    background-color:bisque;
    text-transform: uppercase;
    border-left-color: red; 
    border-left-style: solid;
    border-left-width: 15px;
    padding: 20px 20px 20px 20px;
}

p {
    background-color: lightgray;
    padding: 10px 10px 10px 10px;
    font-size: 20px;
    font: 1em sans-serif;;
}
</style>