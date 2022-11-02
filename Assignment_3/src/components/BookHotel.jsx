import React from "react";
import { useEffect } from "react";
import { useState } from "react";


 const BookHotel = () =>{
    const  [bookdata,setbookdata] = useState([])
   const bookingId = localStorage.getItem('bookingId')
   const [table,setTable] = useState('')
   const [uid,setUid]=useState('')

   const [hname,setHname]=useState('')
    useEffect (()=>{
        const hotelData = localStorage.getItem ("hoteldata")
        setbookdata (JSON.parse(hotelData))
        
    },[])

    const book=()=>{
        bookdata.map((data)=>{
            if (data.id === bookingId){
             setUid(data.id)
              setHname(data.name)
                
            }
        })
       
    }

    const saveData =()=>{
        const bookingArray = JSON.parse(localStorage.getItem("bookingArray")||"[]");
        const obj ={
            uid : uid,
            hname : hname,
            table : table
        }
        bookingArray.push(obj)
        localStorage.setItem('bookingArray',JSON.stringify( bookingArray) ) 
        window.alert("booked succesfully")
    }

    

return (
    <>
    <button onClick={book}>fetchdata</button>
    <div>
    <div className="inputBody m-5">
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>User ID </b>
            </label>
          </span>
          <input
            id="uid"
           value={uid}
           disabled
            className="form-control"
            placeholder="Enter User Id"
            aria-label="With input"
          ></input>
        </div>
        <br />
       
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Hotel Name</b>
            </label>
          </span>
          <input
            id="name"
            value={hname}
            disabled
            className="form-control"
            placeholder="name"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Number of Tables</b>
            </label>
          </span>
          <input
            id="no_of_tb"
            onChange={(e)=>{
                setTable(e.target.value)
            }}
            className="form-control"
            placeholder="No of Tables"
            aria-label="With input"
          ></input>
        </div>
        <div className="successButton mt-3">
         <button className="btn btn-success" onClick={saveData}>Book</button> 
           
        </div>
      </div>
      
    </div>
    </>
)
 }

 export default BookHotel ;