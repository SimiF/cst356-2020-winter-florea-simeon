<template>
    <div>      
    <head>
        <title>Instructor Information</title>
    
        <link rel="stylesheet" href='css/style.css'>               
    </head>

    <body>     
        <h3 class="table_heading">Table 1: List of instructors.</h3>
        <table>
           <thead>
                <tr>
                    <td>First Name</td>
                    <td>Middle Initial</td>
                    <td>Last Name</td>
                </tr>
           </thead>
           <tbody id="instructor_data">

           </tbody>
        </table>
     
    </body>      
    </div>
</template>

<script>
export default {
    name: 'Instructors'
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