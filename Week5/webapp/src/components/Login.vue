<template>
    <div>
        <h1>Login Page</h1>
        <form>

            <div class="form-entry">
                Username: <input id='first-name' type="text" v-model="username"/>
                <span id='first-name-error' v-bind:style="{visibility: usernameErrorVisibility}">Please enter username.</span>
            </div>

            <div class="form-entry">
                Password: <input id='last-name' type="text" v-model="password"/>
                <span id='last-name-error' v-bind:style="{visibility: passwordErrorVisibility}">Please enter password.</span>
            </div>            

            <div class="form-entry">
                <input type="button" value="Register" v-on:click="submitRegistration()"/>
            </div>

        </form>
    </div>
</template>

<script>    
    export default {
        name: 'Login',
        methods: {
            submitRegistration: function() {
                this.usernameErrorVisibility = 'hidden';
                this.passwordErrorVisibility = 'hidden';
                if (this.username.length == 0) {
                    this.usernameErrorVisibility = 'visible';
                    return;
                }
                if (this.password.length == 0) {
                    this.passwordErrorVisibility = 'visible';
                    return;
                }            
            }
        },
        data () {
            return {
                username: '',
                password: ''
            }
        }
    }
</script>

<style scoped>
    form {
        background-color: white;
        padding: 10px;
    }

    .form-entry {
        padding: 10px;
        background-color: lightgray;
    }
</style>