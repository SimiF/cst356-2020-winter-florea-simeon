<template>
  <div>    
    <head>
        <title>Home Page</title>        
        <link rel="stylesheet" href='css/style.css'>      
    </head>

    <body>                
        <h1 id="main_header">Welcome to our page!</h1>
       
        <h3>Lorem ipsum dolor sit amet, consectetur adipiscing elit...</h3>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum non aliquet dui. Vivamus pellentesque pulvinar turpis id consequat. 
            Donec ut ante auctor, vehicula lorem et, rhoncus nulla. Ut ut nulla nibh. Nulla ac turpis elit. Fusce commodo mauris nec dui finibus elementum. 
            Aliquam felis ante, viverra ut justo in, pharetra lacinia ex. Nullam volutpat pellentesque consequat. Vestibulum imperdiet turpis sed purus porttitor viverra. 
            In tellus justo, ultricies in dolor eget, auctor pellentesque ex. Nam non ex eget magna faucibus molestie. Aenean id nulla quis ligula ornare pharetra.</p>

        <h3>Curabitur porttitor dolor et ligula cursus commodo...</h3>
        <p>Curabitur porttitor dolor et ligula cursus commodo. Etiam convallis sed purus sed sollicitudin. 
            In hac habitasse platea dictumst. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. 
            Nam aliquet sem at finibus suscipit. Duis aliquet commodo pulvinar. Nunc tincidunt pulvinar eros, vel volutpat lacus convallis at. 
            Fusce dapibus nulla egestas eros rhoncus, sed vestibulum libero finibus. Vestibulum sed pulvinar urna. Suspendisse nisi nulla, suscipit eget sagittis et, 
            aliquam molestie dolor. Suspendisse lacinia rutrum dictum. Nullam consectetur sapien ac sem dapibus ullamcorper. Sed pharetra quam massa. 
            Donec auctor non felis at tincidunt.</p>

        <h3>Am gravida in erat et fringilla...</h3>
        <p>am gravida in erat et fringilla. Nunc sed magna ante. Morbi et placerat velit. Aenean ut semper libero. Phasellus pulvinar non nisi tempor faucibus. 
            Donec eu neque eget nisl consectetur luctus. Quisque quis purus semper ante venenatis porta vitae sit amet urna. Nunc cursus condimentum vestibulum. 
            Vivamus eget lorem lacus. Quisque vitae efficitur neque. Aliquam placerat urna sed ante ultrices molestie. Duis purus dui, pharetra non feugiat ut, gravida nec purus.</p>

        <img src="../assets/school-img.jpg" alt="Image of School Related Items." width="256" height="256">
    </body>
  </div>
</template>

<script>
export default {
  name: 'Home'
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
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

/*
The following css is inspired from
https://www.w3schools.com/css/css_navbar.asp
*/

ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    float: left;
    background-color: lightgray;
}

li {
    float: left;
}

li a {
    display: block;
    padding: 8px;
    color: red;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: black;
    color: greenyellow;
}
</style>
