function enviarRecojo() {  

  const colruc = 1;
  const colcliente = 2;
  const colcodigo = 3;
  const coldireccion = 4; 
  const colcontacto = 5;
  const colcelular = 6;
  const colcorte = 7; 
  const colsugerido = 8;
  const colhorario = 9;
  const colcomercial = 10;
  const colobs = 11;
  const colenv = 12;

  var hoja = SpreadsheetApp.getActiveSpreadsheet().getSheetByName("Data");

  var correos = "smijail26@gmail.com, sair.medrano@leasein.pe";
  let mensaje="";
  let cadena="";
  let rangoOriginalData=hoja.getRange(2,1,hoja.getLastRow()-1,hoja.getLastColumn());

  rangoOriginalData.sort([
    {column:12, ascending:true},
    {column:1, ascending:false}
  ])

  let dataRango=rangoOriginalData.getValues();
  var filteredDataRango=dataRango.filter(function(item){
    return item[colenv-1]!="Enviado";
  })

  let numRegistros=filteredDataRango.length;
  for(let i=0;i<numRegistros;i++){

    let codigo=filteredDataRango[i][2];
    let fechaCorteAlquiler=filteredDataRango[i][6];
    let fechaRecojo=filteredDataRango[i][7];
    let direccion=filteredDataRango[i][3];
    let personaContacto=filteredDataRango[i][4];
    let telefono=filteredDataRango[i][5];

    cadena += "<tr>";
    cadena += "<td>" + codigo + "</td>";
    cadena += "<td>" + "LAPTOP" + "</td>";
    cadena += "<td>" + fechaCorteAlquiler + "</td>";
    cadena += "<td>" + fechaRecojo + "</td>";
    cadena += "<td>" + direccion + "</td>";
    cadena += "<td>" + personaContacto + "</td>";
    cadena += "<td>" + telefono + "</td>";
    cadena += "</tr>";

    if(i===(numRegistros-1) || filteredDataRango[i][0]!=filteredDataRango[i+1][0]){

      cadena += "</table>  </ body >  </ html > ";

      var cliente = filteredDataRango[i][1];
      var ruc = filteredDataRango[i][0];
      var asunto = "Recojo de equipos a "+cliente

      var body = "<html><head><style> table {width:75%;} table, th, td { border: 1px solid black; border-collapse: collapse; } th, td { padding: 15px; text-align: center; } #t01 tr:nth-child(even) { background-color: #eee; } #t01 tr:nth-child(odd) { background-color: #fff; } #t01 th { background-color: orange; color: white; } </style> </head> <body> <h3>Buenas estimad@,</h3></br> <h3>A continuación se detalla la información sobre el corte de los equipos.</h3></br> <h3>Cliente: " + cliente + "</h3></br> <h3>RUC: " + ruc + "</h3></br> <table id='t01'> <tr> <th>Código Equipo</th> <th>Tipo Equipo</th> <th>Fecha Corte</th> <th>Fecha Sugerida de Recojo</th> <th>Dirección de Recojo</th> <th>Persona de Contacto</th> <th>Celular</th> </tr> ";
  
      body += cadena;
      GmailApp.sendEmail(correos, asunto,'' ,{htmlBody:body});

      body="";
      cadena="";
      asunto="";

    }
  }

  for(let i=2;i<=hoja.getLastRow();i++){
    hoja.getRange(i,colenv).setValue("Enviado");
  }
  Logger.log(hoja.getLastRow());

}