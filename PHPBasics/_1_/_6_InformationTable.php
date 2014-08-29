<?php
$name = "Gosho";
$phoneNumber = "0882-321-423";
$age = 24;
$adress = "Hadji Dimitar";
?>

<!DOCTYPE html>
<html>
    <head>
            <meta charset="utf-8">
            <meta http-equiv="X-UA-Compatible" content="IE=edge">
            <title>_6_InformationTable</title>
            <link rel="stylesheet" type="text/css" href="_6_InformationTable.css">
            
    </head>
    <body>
        <table>
            <tr>
                <td>
                    <?php echo "Name";?>
                </td>
                <td>
                    <?php echo $name;?>
                </td>
            </tr>
            <tr>
                <td>
                    <?php echo "Phone number";?>
                </td>
                <td>
                    <?php echo $phoneNumber;?>
                </td>
            </tr>
            <tr>
                <td>
                    <?php echo "Age";?>
                </td>
                <td>
                    <?php echo $age;?>
                </td>
            </tr>
            <tr>
                <td>
                    <?php echo "Adress";?>
                </td>
                <td>
                    <?php echo $adress;?>
                </td>
            </tr>
            
        </table>
    </body>
</html>



