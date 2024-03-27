

// axios.get('/api/friends')
//   .then(response => {
//     const friends = response.data;
//     friends.forEach(friend => {
//       const div = document.createElement('div');
//       div.id = `friend-${friend.id}`;

//const { default: axios } = require("axios");

//const { default: axios } = require("axios");

//const { default: axios } = require("axios");

      
//       const name = document.createElement('p');
//       name.innerText = friend.name; // Assuming 'name' is a property of your friend object
//       div.appendChild(name);

//       const email = document.createElement('p');
//       email.innerText = friend.email; // Assuming 'email' is a property of your friend object
//       div.appendChild(email);

//       // Add more properties as needed

//       document.body.appendChild(div); // Append the div to the body or another container
//     });
//   })
//   .catch(error => {
//     console.error(error);
//   });

var addressMembers="https://localhost:7129/api/Members";
var addressManufacturer="https://localhost:7129/api/Manufacturer";
var addressVaccination="https://localhost:7129/api/Vaccination";

//const axios = require('axios');

// כשהתוכנית עולה 
function start(){
    axios.get(addressMembers).then((res)=>{
       // var listMem=document.getElementById("listMembers");
        var memberslst=res.data; 
         var selectMembers=document.getElementById("selectMembers");
          var selectMemberAddVac=document.getElementById("selectMemberAddVac");
          var selectUpdateMembers=document.getElementById("selectUpdateMembers");
          var selectDeleteMembers=document.getElementById("selectDeleteMembers");

        memberslst.forEach(member => {
         
           o1=document.createElement("option");
           o2=document.createElement("option");
           o3=document.createElement("option");
           o4=document.createElement("option");

           //לבדוק איזה קוד זיהוי כדאי
           //הוספת חיסון קלטים
           o1.text=member.name+" "+member.lastName;
           o1.value=member.codeMem;
           o2.value=member.codeMem;
           o2.text=member.id+" "+member.name+" "+member.lastName;
           o3.text=member.name+" "+member.lastName;
           o3.value=member.codeMem;
           o4.text=member.name+" "+member.lastName;
           o4.value=member.codeMem;
           selectMembers.appendChild(o1);
           selectMemberAddVac.appendChild(o2);
           selectUpdateMembers.appendChild(o3);
           selectDeleteMembers.appendChild(o4);

           
           
            // var div=document.createElement('div');
            // div.id=`member-${member.id}`

            // var name=document.createElement('p');
            // name.innerText=member.Name+" "+member.LastName;
            // div.appendChild(name);

            // listMem.appendChild(div);
        });

    }) 
    axios.get(addressManufacturer).then((res)=>{
      var Manufacturerlst=res.data;
      var selectManufacurer=document.getElementById("selectManufacurer");
      Manufacturerlst.forEach(manufacturer=>{
         o5=document.createElement("option");
         o5.value=manufacturer.codeMan;
         o5.text=manufacturer.name;
         selectManufacurer.appendChild(o5);
      })
    })
}

//הצהגת פרטי חבר
function showDetails(){


  var details=document.getElementById("fromDetails");
  details.innerHTML=' ';
  var s=document.getElementById("selectMembers");
  var name=document.createElement("p");
  var lastName=document.createElement("p");
  var id=document.createElement("p");
  var dob=document.createElement("p");
  var address=document.createElement("p");
  var phone=document.createElement("p");
  var mobilePhone=document.createElement("p");
  var ill=document.createElement("p");
  var recovery=document.createElement("p");
  var countVac=document.createElement("p");
  var code=s[s.selectedIndex].value;

  index=s.selectedIndex
  axios.get(addressMembers).then((res) => {
    name.innerText=res.data[index].name;
    lastName.innerText=(res.data[index].lastName);
    id.innerText=res.data[index].id;
    dob.innerText=res.data[index].dob;
    address.innerText=res.data[index].address;
    phone.innerText=res.data[index].phone;
    mobilePhone.innerText=res.data[index].mobilePhone;
    ill.innerText=res.data[index].ill;
    recovery.innerText=res.data[index].recovery;
    countVac.innerText=res.data[index].countVac;
  })
  axios.get(addressVaccination).then((res)=>{
    var lstVac=res.data;
    lstVac.forEach(vaccination=>{
      if(vaccination.codeMem==code){
         vac=document.createElement("p");
         if(vaccination.codeMan==1)
            {
              var  man="faizer"
            }
          vac.innerText=vaccination.date+" "+man;
          details.appendChild(vac);
      }
    })
  })

    details.appendChild(name);
    details.appendChild(lastName);
    details.appendChild(id);
    details.appendChild(dob);
    details.appendChild(address);
    details.appendChild(phone);
    details.appendChild(mobilePhone);
    details.appendChild(ill);
    details.appendChild(recovery);
    details.appendChild(countVac);

}
//function getMemberByIg(id){}





//הוספת חבר
function addMember(){
    var name=document.getElementById("nameAdd").value;
    var lastName=document.getElementById("lastNameAdd").value;
    var id=document.getElementById("idAdd").value;
    var dob=document.getElementById("DobAdd").value;
    var address=document.getElementById("addressAdd").value;
    var phone=document.getElementById("phoneAdd").value;
    var mobilePhone=document.getElementById("mobilePhoneAdd").value;
   // var ill="00/00/0000";
   // var recovery="00/00/0000";
   // var countVac=0;

    axios.post(addressMembers,{
      "Name":name,
      "LastName":lastName,
      "Id":id,
      "Address":address,
      "Dob":dob,
      "Phone":phone,
      "MobilePhone":mobilePhone,
    }).then((res) => 
    {
      console.log(res.data);
      location.reload();
    })
}
//מילוי ה inputs לעידכון
function fill(){
  var s=document.getElementById("selectUpdateMembers");
  var name=document.getElementById("nameUpdate");
  var lastName=document.getElementById("lastNameUpdate");
  var id=document.getElementById("idUpdate");
  var dob=document.getElementById("DobUpdate");
  var address=document.getElementById("addressUpdate");
  var phone=document.getElementById("phoneUpdate");
  var mobilePhone=document.getElementById("mobilePhoneUpdate");
  var ill=document.getElementById("illUpdate");
  var recovery=document.getElementById("recoveryUpdate");
  var countVac=document.getElementById("countVac");

//
  index=s.selectedIndex
  axios.get(addressMembers).then((res) => {
    name.value=res.data[index].name;
    lastName.value=(res.data[index].lastName);
    id.value=res.data[index].id;
    dob.value=res.data[index].dob;
    address.value=res.data[index].address;
    phone.value=res.data[index].phone;
    mobilePhone.value=res.data[index].mobilePhone;
    ill.value=(res.data[index].ill);
    recovery.value=res.data[index].recovery;
    countVac=res.data[index].countVac;
  })
}
//עידכון חבר
function updateMember(){
  var s=document.getElementById("selectUpdateMembers");
  var name=document.getElementById("nameUpdate").value;
  var lastName=document.getElementById("lastNameUpdate").value;
  var id=document.getElementById("idUpdate").value;
  var dob=document.getElementById("DobUpdate").value;
  var address=document.getElementById("addressUpdate").value;
  var phone=document.getElementById("phoneUpdate").value;
  var mobilePhone=document.getElementById("mobilePhoneUpdate").value;
  var ill=document.getElementById("illUpdate").value;
  var recovery=document.getElementById("recoveryUpdate").value;
  var countVac=document.getElementById("countVac").value;
  code=s[s.selectedIndex].value;
  axios.put(`${addressMembers}/${code}`,{
    "Name":name,
      "LastName":lastName,
      "Id":id,
      "Address":address,
      "Dob":dob,
      "Phone":phone,
      "MobilePhone":mobilePhone,
      "Ill":ill,
      "Recovery":recovery, 
      //לא לשנות חיסון, אבל האם צריך להופיע?  
  }).then((res)=>{
    console.log(res.data);
    location.reload();
  })
}

//מחיקת חבר
function DeleteMember(){
  var s=document.getElementById("selectDeleteMembers");
  code=s[s.selectedIndex].value
  axios.delete(`${addressMembers}/${code}`).then((res) => 
    {
      console.log(res.data);
      location.reload();
    })
    }
    // axios.get(addressVaccination).then((res)=>{
    //   var lstVac=res.data;
    //   lstVac.forEach(vaccination=>{
    //     if(vaccination.members.codeMem==code){
    //       axios.delete(`${addressVaccination}/${code}`).then((res)=>{
    //         console.log(res.data);
    //       })
    //     }
    //     location.reload();
    //   })
    // })
 


//הוסף חיסון
function addVaccination(){
  //var theMember
  var date=document.getElementById("dateAdd").value;
  var manufacturer=document.getElementById("selectManufacurer");
  var member=document.getElementById("selectMemberAddVac");
  var manufacturerCode=manufacturer[manufacturer.selectedIndex].value;
  var memberCode=member[member.selectedIndex].value;
  // theMember=axios.get(`${addressMembers}/${memberCode}`).then((res)=>{
  //   //  theMember=res.data;
  //   console.log(res.data);
  // })
    
 
//   axios.get(`${addressManufacturer}/${manufacturerCode}`).then((res)=>{
//     var theManufacturer=res.data;
//  })
  var date=document.getElementById("dateAdd").value;
  
  axios.post(addressVaccination,{
      "dateOfVaccination": date,
      "manufacturer": null,
      "codeMan": manufacturerCode,
      "members": null,
      "codeMem": memberCode  
  }).then((res)=>{
    console.log(res.data);
    if(res.data==null)
    {
      alert("there is alardy 4 vaccination")
    }
  })
}




