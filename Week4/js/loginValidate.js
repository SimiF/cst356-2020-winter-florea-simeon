function validate() {
    document.getElementById('username-error').style.visibility = 'hidden'
    document.getElementById('password-error').style.visibility = 'hidden'

    var username = document.getElementById('username').value
    var password = document.getElementById('password').value

    if (username == '') {
        document.getElementById('username-error').style.visibility = 'visible'
    }

    if (password == '') {
        document.getElementById('password-error').style.visibility = 'visible'
    }
}