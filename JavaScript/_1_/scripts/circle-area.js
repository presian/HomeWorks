function area() {
    var r = document.getElementById('radius').value;
    var s = Math.PI * (r * r);
    document.body.innerHTML += "r = " + r + "; area = " + s + "<br/>";
    alert(s);
}