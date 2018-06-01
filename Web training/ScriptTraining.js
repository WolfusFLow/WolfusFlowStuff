var x = 10;
var heh = "rafla 223 ' \'asdasds\'"
var age = 20;


document.writeln(heh, x);
document.writeln(10 == '10');
document.writeln(10 === '10', "<br>");
document.writeln((age>18 ? "Good for you" : "Too young"), "<br>")
document.writeln(Date());

var myNum1 = 6;
var myNum2 = 12;
if (myNum1 > myNum2) {
   alert("This page is Michael's playground.)))");
}

/*
document.writeln('I am at' + mydata.address.streetAddress);

$(function() {
        var x = JSON.parse($('#myJson').html());
        alert(x.name); //Foo
     });
*/

/*
var textsegment = document.querySelector('section');
var requestURL = "kl.json";
var request = new XMLHttpRequest();
request.open('GET', requestURL);
request.responseType = 'json';
request.send();

function inserttext(jsonObj){
  var ins = document.createElement('p');
  ins.textContent = jsonObj['textstring'];
  insertingtext.appendChild(ins);
}
*/

$.getJSON("data.json", function(data) {
      var output = "textstring";
        document.getElementById("insertingtext").innerHTML=output;
  });

  function show(state){
    document.getElementById('Hideandshow').style.display=state;
    document.getElementById('wrap').style.display=state;
  }



  $('.fade').slick({
    dots: true,
    infinite: true,
    speed: 500,
    fade: true,
    cssEase: 'linear'
  });
