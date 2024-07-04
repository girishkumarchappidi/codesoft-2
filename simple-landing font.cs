body{
    background-color: rgb(34,34,34);
    color: white;
    font-family: poppinsregular;
    max-width: 1200px;
    margin: 0 auto;
    padding: 15px;
    padding-bottom: 100px;
    min-height: 100vh;
    position: relative;
}

header{
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

#title{
flex-direction: column;
line-height: 10px;
}

li{
    display: inline-block;
    margin: 20px;
}

a{
    color: white;
}

a:hover{
    color: #e58a1f;
    transition: 0.3 all;
}

h1{
    font-weight: 200;
}

main{
    padding-bottom: 50px;
    display: flex;
    flex-direction: row;
    margin-top: 50px;

}

h2{
    font-size: 56px;
    line-height: 10px;
    font-family: poppinsmedium;
}

span{
    color: #e58a1f;
}

p{
    text-align: justify;
    line-height: 20px;
    max-width: 500px;
    font-family: poppinslight;
}

img{
    width: 620px;
}

form{
    display: flex;
    flex-direction: column;
    width: 70%;
}

form [type="submit"]{
    height: 50px;
    width: 50%;
    background-color: #e58a1f;
    color: white;
    font-weight: bold;
}

form [type="submit"]:hover{
    cursor: pointer;
}

input{
    margin-top: 20px;
    height: 20px;
    padding: 15px;
    border-radius: 20px;
    border: none;
}

footer{
    font-family: poppinslight;
    padding: 15px;
    margin-bottom: 0;
    font-size: 10px;
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    background-color: #2e2c2c;
    color: white;
    text-align: right;
    display: flex;
    justify-content: center;
}

article{
    padding-left: 110px;
}
