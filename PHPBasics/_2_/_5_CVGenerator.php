<?php header('Content-Type: text/html; charset=utf-8'); ?>
<!DOCTYPE html>

<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title></title>
            <link rel = "stylesheet" href = "styles/_5_CVGenerator.css">
    </head>
    <body>
        <script>
            var nextPL =0;
            function addProgLang() {
                nextPL++;
                var div = document.createElement("div");
                div.setAttribute("id", "input"+nextPL);
                div.innerHTML='<input type="text" name= "inputs[]">'+
                '<select name="progLangLevel[]" required="true">'+
                '<option value="beginner">Beginner</option>'+
                '<option value="programmer">Programmer</option>'+
                '<option value="senior">Senior</option>'+
                '</select>';
                document.getElementById("programLang").appendChild(div);
            } 
            function removeProgLang() {
                var element = document.getElementById('programLang').lastChild;
                if (element.id!='input1') {
                    document.getElementById('programLang').removeChild(element);
                }
            }
            var nextL = 0;
            function addLang() {
                nextL++;
                var langdiv = document.createElement('div');
                langdiv.setAttribute("id",'langdiv'+nextL);
                langdiv.innerHTML='<input type="text" name="langs[]">'+
                        '<select name="comprehension[]" required="true">'+
                        '<option value="default" disabled selected>-Comprehension-</option>'+
                        '<option value="beginners">Beginner</option>'+
                        '<option value="intermediate">Intermediate</option>'+
                        '<option value="advanced">Advanced</option>'+
                        '</select>'+
                        '<select name="reading[]" required="true">'+
                        '<option value="default" disabled selected>-Reading-</option>'+
                        '<option value="beginners">Beginner</option>'+
                        '<option value="intermediate">Intermediate</option>'+
                        '<option value="advanced">Advanced</option>'+
                        '</select>'+
                        '<select name="writing[]" required="true">'+
                        '<option value="default" disabled selected >-Writing-</option>'+
                        '<option value="beginners">Beginner</option>'+
                        '<option value="intermediate">Intermediate</option>'+
                        '<option value="advanced">Advanced</option>'+
                        '</select>';
                document.getElementById('langs').appendChild(langdiv);
            }
            function removeLang() {
                var lang = document.getElementById('langs').lastChild;
                if (lang.id!='langdiv1') {
                document.getElementById('langs').removeChild(lang);
                }
            } 
        </script>
        <div id="window">
            <form action="_5_CVGenerator.php" method="GET">
                <fieldset>
                    <legend>Personal information</legend>
                    <input type="text" placeholder="First Name" autofocus name="fname"><br>
                    <input type="text" placeholder="Last Name" name="lname" ><br>
                    <input type="email" placeholder="Email" name="email"><br>
                    <input type="tel" placeholder="Phone Number" name="phone"><br>
                    <label for="female">Female</label>
                    <input type="radio" name="gender" id="female" value="Female">
                    <label for="male">Male</label>
                    <input type="radio" name="gender" id="male" value="Male"><br>
                    <label for="birthdate">Birth Date</label><br>
                    <input type="text" id="birthdate" placeholder="dd/mm/yyyy" name="birthdate"><br>
                    <label for="nationality">Nationality</label><br>
                    <select id="nationality" name="nationality">
                        <option disabled selected>-Nationality-</option>
                        <option value="Bulgarian">Bulgarian</option>
                        <option value="German">German</option>
                        <option value="English">English</option>
                    </select>
                </fieldset>
                <fieldset>
                    <legend>Last Work Position</legend>
                    <label for="company">Company Name</label>
                    <input type="text" name="company" id="company"><br>
                    <label for="from">From</label>
                    <input type="text" name="from" id="from" placeholder="dd/mm/yyyy"><br>
                    <label for="to">To</label>
                    <input type="text" name="to" id="to" placeholder="dd/mm/yyyy"><br>
                </fieldset>
                <fieldset>
                    <legend>Computer Skills</legend>
                    <label for="programLang">Programming languages</label><br>
                    <div id="programLang" name="programLang">
                        <script>addProgLang();</script>
                    </div>
                    <input type="button" value="Remove language" onclick="javascript:removeProgLang()">
                    <input type="button" value="Add language" onclick="javascript:addProgLang()">
                </fieldset>
                <fieldset>
                    <legend>Others Skills</legend>
                    <label>Languages</label><br>
                    <div id="langs"></div>
                    <script>addLang();</script>
                    <input type="button" value="Remove language" onclick="javascript:removeLang()">
                    <input type="button" value="Add language" onclick="javascript:addLang()"><br>
                    <label>Driver's License</label><br>
                    <label>B</label>
                    <input type="checkbox" name="categoryB" value="B">
                    <label>A</label>
                    <input type="checkbox" name="categoryA" value="A">
                    <label>C</label>
                    <input type="checkbox" name="categoryC" value="C">
                </fieldset>
                <input type="submit" value="Generate CV" name="submit">
            </form>
        </div>
        <div id="result">
            <h1>CV</h1>
<?php 
if ((isset($_GET['submit']))&&(isset($_GET['fname']))&&(isset($_GET['lname']))&&(isset($_GET['email']))&&(isset($_GET['phone']))&&(isset($_GET['gender']))&&(isset($_GET['birthdate']))&&(isset($_GET['nationality'])&&(isset($_GET['company']))&&(isset($_GET['from']))&&(isset($_GET['to'])))&&(isset($_GET['inputs']))&&(isset($_GET['progLangLevel']))&&(isset($_GET['langs']))&&(isset($_GET['comprehension']))&&(isset($_GET['reading']))&&(isset($_GET['writing']))) {
    //============================================================
    //make variables for every point
    //============================================================
    $fname=$_GET['fname'];
    $lname=$_GET['lname'];
    $email=$_GET['email'];
    $phone=$_GET['phone'];
    $gender=$_GET['gender'];
    $birthdate=$_GET['birthdate'];
    $nationality=$_GET['nationality'];
    $company=$_GET['company'];
    $from=$_GET['from'];
    $to=$_GET['to'];
    $progLangs=$_GET['inputs'];
    $progLangLevel=$_GET['progLangLevel'];
    $langs=$_GET['langs'];
    $comprehension=$_GET['comprehension'];
    $reading=$_GET['reading'];
    $writing=$_GET['writing'];
    $categoryB='';
    $categoryA='';
    $categoryC='';
    
    if (isset($_GET['categoryB'])) {
        $categoryB = $_GET['categoryB'];
    }
    if (isset($_GET['categoryA'])) {
        $categoryA = $_GET['categoryA'];
    }
    if (isset($_GET['categoryC'])) {
        $categoryC = $_GET['categoryC'];
    }
    //===========================================================
    //validation and output
    //===========================================================
     if(!preg_match('/[^A-Za-z]/', $fname) && !preg_match('/[^A-Za-z]/', $lname)
            && !preg_match('/[^A-Za-z0-9 ]/', $company) && strlen($fname) <= 20 && strlen($fname) >= 2 &&
            strlen($lname) <= 20 && strlen($lname) >= 2 &&
            strlen($company) <= 20 && strlen($company) >= 2 &&
            !preg_match("/^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$/", $birthdate) &&
            !preg_match('/[^0-9\+\-\s]/', $phone)
        ) {
            $personalInfoTable = '<table><thead><tr><th colspan="2">Personal Information</th></tr></thead><tbody>' .
                '<tr><td>First Name</td><td>' . $fname . '</td></tr><td>Last Name</td><td>' . $lname  . '</td></tr>' .
                '<tr><td>Email</td><td>' . $email . '</td></tr>' .
                '<tr><td>Phone</td><td>' . $phone . '</td></tr>' .
                '<tr><td>Gender</td><td>' . $gender . '</td></tr>' .
                '<tr><td>Birth Date</td><td>' . $birthdate . '</td></tr>' .
                '<tr><td>Nationality</td><td>' . $nationality . '</td></tr></tbody></table>';
            $lastWorkTable = '<table><thead><tr><th colspan="2">Last Work Position</th></tr></thead><tbody>' .
                '<tr><td>Company Name</td><td>' . $company . '</td></tr>' .
                '<tr><td>From</td><td>' . $from . '</td></tr>' .
                '<tr><td>To</td><td>' . $to . '</td></tr></tbody></table>';
            $computerSkillsTable = '<table><thead><tr><th colspan="2">Computer Skills</th></tr></thead><tbody>' .
                '<tr><td>Programming Languages</td><td><table><thead><tr><th>Language</th><th>Skill Level</th></tr></thead>' .
                '<tbody>';
            $l = count($progLangs);
            for($i = 0; $i < $l ;$i++) {
                $computerSkillsTable .= '<tr>';
                $computerSkillsTable .= '<td>' . $progLangs[$i] . '</td>';
                $computerSkillsTable .= '<td>' . $progLangLevel[$i] . '</td>';
                $computerSkillsTable .= '</tr>';

            }
            $computerSkillsTable .= '</tbody></table></tr></tbody></table>';

            $otherSkills = '<table><thead><tr><th colspan="2">Other Skills</th></tr></thead><tbody>' .
                '<tr><td>Languages</td><td><table><thead><th>Language</th><th>Comprehension</th>' .
                '<th>Reading</th><th>Writing</th></tr>';
            $length = count($langs);
            for($i = 0; $i < $length ;$i++) {
                $otherSkills .= '<tr>';
                $otherSkills .= '<td>' . $langs[$i] . '</td>';
                $otherSkills .= '<td>' . $comprehension[$i] . '</td>';
                $otherSkills .= '<td>' . $reading[$i] . '</td>';
                $otherSkills .= '<td>' . $writing[$i] . '</td>';
            }
            $otherSkills .= '</tbody></table></tr><tr><td>Driver`s License</td><td>' . $categoryB . " ".  $categoryA. " " . $categoryC .'</td></tr>';
            $otherSkills .= '</tbody></table>';
        }
             if(isset($personalInfoTable) && isset($lastWorkTable) && isset($computerSkillsTable) && $otherSkills) {
            echo $personalInfoTable;
            echo $lastWorkTable;
            echo $computerSkillsTable;
            echo $otherSkills;
        }
        else {
            echo "Please enter a valid information to generate your CV";
        }
}
//print_r($_GET);
?>
        </div>
    </body>
</html>
