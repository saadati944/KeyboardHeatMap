using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboardHeatMap.IO
{
    public static class HtmlLayout
    {
        public const string Prefix = @"<!Doctype html>
<html>

<body>
    <style>
        body {
            margin: 0;
        }

        .container {
            display: block;
            height: 47px;
            overflow-y: visible;
        }

        .line {
            display: inline-flex;
            /* border: 1px solid black; */
        }

        .key {
            display: block;
            /* position: relative; */
            border: 1px solid black;
            border-radius: 5px;
            /* width: 50px;
                height: 50px; */
            padding: 0;
        }

        .size_small_width {
            width: 42.14px;
        }

        .size_one_half_width {
            width: 69px;
        }

        .size_one_half_plus_width {
            width: 80px;
        }


        .size_one_half_plus_plus_width {
            width: 100px;
        }

        .size_one_width {
            width: 45px;
        }

        .size_one_height {
            height: 45px;
        }

        .size_two_width {
            width: 93px;
        }

        .size_two_plus_width {
            width: 105px;
        }

        .size_two_plus_plus_width {
            width: 132px;
        }

        .size_four_width {
            width: 185px;
        }

        .size_two_height {
            height: 92px;

        }

        .keycode {
            display: block;
            position: relative;
            width: fit-content;
            height: fit-content;
            transform: translate(-50%, -50%);
            top: 50%;
            left: 50%;
            margin: 0;
            /* outline: 1px solid red; */
        }

        .empty_key {
            border: 1px solid white;
        }
    </style>
</body>

<body>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='Escape' class='key size_small_width size_one_height'><p class='keycode'>ESC</p></div>
            <div keycode='F1' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F2' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F3' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F4' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F5' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F6' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F7' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F8' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F9' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F10' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F11' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F12' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='F12' class='key size_small_width size_one_height'><p class='keycode'></p></div>
            <div keycode='Print' class='key size_small_width size_one_height'><p class='keycode'>PrtScr</p></div>
            <div keycode='Pause' class='key size_small_width size_one_height'><p class='keycode'>Pause</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='Home' class='key size_one_width size_one_height'><p class='keycode'></p></div>
            <div keycode='PageUp' class='key size_one_width size_one_height'><p class='keycode'>PgUp</p></div>
            <div keycode='PageDown' class='key size_one_width size_one_height'><p class='keycode'>PgDn</p></div>
            <div keycode='End' class='key size_one_width size_one_height'><p class='keycode'></p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='Oemtilde' class='key size_one_height size_one_width'><p class='keycode'>`</p></div>
            <div keycode='D1' class='key size_one_height size_one_width'><p class='keycode'>1</p></div>
            <div keycode='D2' class='key size_one_height size_one_width'><p class='keycode'>2</p></div>
            <div keycode='D3' class='key size_one_height size_one_width'><p class='keycode'>3</p></div>
            <div keycode='D4' class='key size_one_height size_one_width'><p class='keycode'>4</p></div>
            <div keycode='D5' class='key size_one_height size_one_width'><p class='keycode'>5</p></div>
            <div keycode='D6' class='key size_one_height size_one_width'><p class='keycode'>6</p></div>
            <div keycode='D7' class='key size_one_height size_one_width'><p class='keycode'>7</p></div>
            <div keycode='D8' class='key size_one_height size_one_width'><p class='keycode'>8</p></div>
            <div keycode='D9' class='key size_one_height size_one_width'><p class='keycode'>9</p></div>
            <div keycode='D0' class='key size_one_height size_one_width'><p class='keycode'>0</p></div>
            <div keycode='OemMinus' class='key size_one_height size_one_width'><p class='keycode'>-</p></div>
            <div keycode='Oemplus' class='key size_one_height size_one_width'><p class='keycode'>=</p></div>
            <div keycode='Backspace' class='key size_one_height size_two_width'><p class='keycode'>←</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='NumLock' class='key size_one_height size_one_width'><p class='keycode'>NL</p></div>
            <div keycode='Divide' class='key size_one_height size_one_width'><p class='keycode'>/</p></div>
            <div keycode='Multiply' class='key size_one_height size_one_width'><p class='keycode'>*</p></div>
            <div keycode='Subtract' class='key size_one_height size_one_width'><p class='keycode'>-</p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='Tab' class='key size_one_height size_one_half_width'><p class='keycode'></p></div>
            <div keycode='Q' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='W' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='E' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='R' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='T' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='Y' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='U' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='I' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='O' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='P' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='Oem4' class='key size_one_height size_one_width'><p class='keycode'>[</p></div>
            <div keycode='OemCloseBrackets' class='key size_one_height size_one_width'><p class='keycode'>]</p></div>
            <div keycode='Oem5' class='key size_one_height size_one_half_width'><p class='keycode'>\</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='NumPad7' class='key size_one_height size_one_width'><p class='keycode'>7</p></div>
            <div keycode='NumPad8' class='key size_one_height size_one_width'><p class='keycode'>8</p></div>
            <div keycode='NumPad9' class='key size_one_height size_one_width'><p class='keycode'>9</p></div>
            <div keycode='Add' class='key size_two_height size_one_width'><p class='keycode'>+</p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='CapsLock' class='key size_one_height size_one_half_plus_width'><p class='keycode'></p></div>
            <div keycode='A' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='S' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='D' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='F' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='G' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='H' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='J' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='K' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='L' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='Oem1' class='key size_one_height size_one_width'><p class='keycode'>;</p></div>
            <div keycode='Oem7' class='key size_one_height size_one_width'><p class='keycode'>'</p></div>
            <div keycode='Enter' class='key size_one_height size_two_plus_width'><p class='keycode'></p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='NumPad4' class='key size_one_height size_one_width'><p class='keycode'>4</p></div>
            <div keycode='NumPad5' class='key size_one_height size_one_width'><p class='keycode'>5</p></div>
            <div keycode='NumPad6' class='key size_one_height size_one_width'><p class='keycode'>6</p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='LShift' class='key size_one_height size_one_half_plus_plus_width'><p class='keycode'>Shift</p></div>
            <div keycode='Z' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='X' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='C' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='V' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='B' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='N' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='M' class='key size_one_height size_one_width'><p class='keycode'></p></div>
            <div keycode='Oemcomma' class='key size_one_height size_one_width'><p class='keycode'>,</p></div>
            <div keycode='OemPeriod' class='key size_one_height size_one_width'><p class='keycode'>.</p></div>
            <div keycode='OemQuestion' class='key size_one_height size_one_width'><p class='keycode'>/</p></div>
            <div keycode='RShift' class='key size_one_height size_two_plus_plus_width'><p class='keycode'>Shift</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='NumPad1' class='key size_one_height size_one_width'><p class='keycode'>1</p></div>
            <div keycode='NumPad2' class='key size_one_height size_one_width'><p class='keycode'>2</p></div>
            <div keycode='NumPad3' class='key size_one_height size_one_width'><p class='keycode'>3</p></div>
            <div keycode='Enter' class='key size_two_height size_one_width'><p class='keycode'></p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='LControl' class='key size_one_height size_one_half_plus_width'><p class='keycode'>CTRL</p></div>
            <div keycode='LWin' class='key size_one_height size_one_width'><p class='keycode'>WIN</p></div>
            <div keycode='LMenu' class='key size_one_height size_one_width'><p class='keycode'>ALT</p></div>
            <div keycode='Space' class='key size_one_height size_four_width'><p class='keycode'></p></div>
            <div keycode='RAlt' class='key size_one_height size_one_width'><p class='keycode'>ALT</p></div>
            <div keycode='Apps' class='key size_one_height size_one_width'><p class='keycode'>MENU</p></div>
            <div keycode='RControl' class='key size_one_height size_one_half_width'><p class='keycode'>CTRL</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div keycode='Up' class='key size_one_height size_one_width'><p class='keycode'>↑</p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div class='key size_one_width size_one_height empty_key'><p class='keycode'></p></div>
            <div class='key size_one_width size_one_height empty_key' style='width: 35px;'><p class='keycode'></p></div>
            <div keycode='NumPad0' class='key size_one_height size_two_width' style='width: 92px;'><p class='keycode'>0</p></div>
            <div keycode='Decimal' class='key size_one_height size_one_width'><p class='keycode'>.</p></div>
        </div>
    </div>
    <div class='container'>
        <div class='line'>
            <div keycode='' class='key size_one_height size_one_half_plus_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_one_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_one_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_four_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_one_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_one_width empty_key'><p class='keycode'></p></div>
            <div keycode='' class='key size_one_height size_one_half_width empty_key'><p class='keycode'></p></div>
            <div keycode='Left' class='key size_one_width size_one_height'><p class='keycode'>←</p></div>
            <div keycode='Down' class='key size_one_height size_one_width'><p class='keycode'>↓</p></div>
            <div keycode='Right' class='key size_one_width size_one_height'><p class='keycode'>→</p></div>
        </div>
    </div>
</body>
<script>";

        // example of main body
        //let maxCount = 20;
        //let KeysCount = {
        //    'ESC': 7,
        //    'A': 2,
        //    'B': 3,
        //    'C': 4,
        //    'D': 5,
        //    'E': 6,
        //    'F': 7,
        //    'G': 8,
        //    'H': 9,
        //}

        public const string Suffix = @"
    let containers = document.getElementsByClassName('line');
    for (let j = 0; j < containers.length; j++) {
        let keys = containers[j];
        for (let i = 0; i < keys.children.length; i++) {
            let key = keys.children[i]
            let keycode = key.getAttribute('keycode');
            if (keycode != null) {
                if (key.children.length > 0 && key.children[0].textContent == '')
                    key.children[0].textContent = keycode;

                let colorfraction = KeysCount[keycode];
                if(colorfraction == undefined)
                    continue;

                key.style.backgroundColor = 'rgb(' + (255 - (colorfraction/maxCount * 255)) + ', 0, 0)';
            }
        }
    }
</script>

</html>";
    }
}
