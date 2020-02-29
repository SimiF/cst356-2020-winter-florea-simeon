<template>
    <div>
        <div v-if='operation == "list"'>
            <h2 class='section-heading'>Students</h2>
            <table>
                <thead>
                    <tr>
                        <th>Student ID</th>
                        <th>Email</th>                        
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="student in students" :key="student.StudentId">
                        <td>{{ student.StudentId }}</td>
                        <td>${{ student.Email }}</td>
                        <td>
                            <button v-on:click='displayStudentDetails(student.StudentId)'>Details</button>
                            <button v-on:click='displayUpdateStudent(student.StudentId)'>Update</button>
                            <button v-on:click='deleteStudent(student.StudentId)'>Delete</button>
                        </td>
                    </tr>
                </tbody>
            </table>

            <button id='addBtn' v-on:click='displayAddStudent()'>Add Student</button>
        </div>

        <div v-if='operation == "add"'>
            <h2 class='section-heading'>Add Student</h2>
        
            <form>
                <div class='form-entry'>
                    Name: <input type='text' v-model='StudentId'/>
                </div>

                <div class='form-entry'>
                    Price: <input type='text' v-model='Email'/>
                </div>              

                <div class='form-entry'>
                    <button v-on:click='addStudent'>Add Student</button>
                    <button v-on:click='cancel'>Cancel</button>
                </div>
            </form>

        </div>

        <div v-if='operation == "detail"'>
            <h2 class='section-heading'>Student Detail</h2>

            <div class='form-entry'>
                Student Id: {{ StudentId }}
            </div>

            <div class='form-entry'>
                Email: {{ Email }}
            </div>

            <div class='form-entry'>
                <button v-on:click='cancel'>Ok</button>
            </div>
        </div>

        <div v-if='operation == "update"'>
            <h2 class='section-heading'>Update Student</h2>
        
            <form>
                <div class='form-entry'>
                    Student Id: {{ StudentId }}
                </div>

                <div class='form-entry'>
                    Email: {{ Email }}
                </div>

                <div class='form-entry'>
                    <button v-on:click='updateStudent'>Update Student</button>
                    <button v-on:click='cancel'>Cancel</button>
                </div>
            </form>
        </div>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                StudentId: undefined,
                Email: undefined,                
                StudentUpdateId: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },

        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/Student`;

                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            getStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/Student/${studentId}`;

                Vue.axios.get(url).then(
                    (response) => {
                        this.StudentId = response.data.StudentId;
                        this.Email = response.data.Email;                        
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            displayAddStudent: function() {
                this.StudentId = undefined;
                this.Email = undefined;                

                this.operation = 'add';
            },

            addStudent: function() {
                let url = `http://${this.apiServer}/api/Student`;

                Vue.axios.post(url, {
                    StudentId: this.name,
                    Email: this.Email
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            displayStudentDetails: function(studentId) {
                this.getStudent(studentId);

                this.operation = 'detail';
            },

            displayUpdateStudent: function(studentId) {
                this.productStudentId = studentId;
                this.getStudent(studentId);

                this.operation = 'update';
            },

            updateStudent: function() {
                let url = `http://${this.apiServer}/api/Student/${this.studentUpdateId}`;

                Vue.axios.put(url, {
                    StudentId: this.name,
                    Email: this.Email
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            deleteStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/Student/${studentId}`;

                Vue.axios.delete(url).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            cancel: function() {
                this.operation = 'list';
            }
        },

        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
</script>

<style scoped>

    table {
        border-collapse: collapse;
    }

    table, th, td {
        border: 1px solid black;
        padding: 10px;
    }

    #addBtn {
        margin-top: 20px;
    }

    .form-entry {
        margin-top: 20px;
    }

</style>