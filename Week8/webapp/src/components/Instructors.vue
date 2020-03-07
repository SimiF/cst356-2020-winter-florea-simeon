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
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
           </thead>
           <tbody>
               <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.firstName }}</td>
                    <td>{{ instructor.middleI }}</td>                
                    <td>{{ instructor.lastName }}</td>
                </tr>
           </tbody>
        </table>
     
    </body>      
    </div>
</template>

<script>
 export default {
        name: 'Instructors',
        mounted() {
            this.instructors = getStudents();
        },
        data () {
            return {
                instructors: []
            }
        }
    }

    function getStudents() {
        return JSON.parse(instructors);
    }

    var instructors = '[{"firstName":"Marcos", "middleI":"D", "lastName":"Monroig"}, {"firstName":"Myrta", "middleI":"S", "lastName":"Merten"}, {"firstName":"Marco", "middleI":"I", "lastName":"Lovell"}, {"firstName":"Janiece", "middleI":"A", "lastName":"Kroeker"}, {"firstName":"Hilario", "middleI":"M", "lastName":"Rose"}]'
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