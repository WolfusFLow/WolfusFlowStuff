
$(document).ready(function(){
$('.callnumber').load('Tel1.txt');
});
/*
function readEmailFile(evt){
  var f = evt.target.files[0];
  if (f){
    var r = new FileReader();
    r.onload = function(e){
      var contents = e.target.result;
      alert("Got the file.n");
    }
    r.readAsText(f);
  } else{
    alert("Faild to load file");
  }
}
var sendemail = "mailto:"+r;
document.getElementById('emailtextadress').innerHTML=r;
document.getElementById('emailadress').href=sendemail;
*/

//alert(sendemail);


/*
var email = new XMLHttpRequest();
email.open('GET', '/email.txt');
email.onreaystatechange = function(){
  alert(email);
}
email.send();

getElementbyId()
https://www.trevor-davis.com/blog/ajax-forms-with-jquery/
*/
