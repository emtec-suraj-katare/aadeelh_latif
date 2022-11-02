import React from "react";
import { useEffect } from "react";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";

const Showhotel =()=>{
    const  [hotelArr,setArr] = useState([])
   
    useEffect (()=>{
        const hotelData = localStorage.getItem ("hoteldata")
        setArr (JSON.parse(hotelData))
        
    },[])
    
    const navigate = useNavigate()

    let [add,setAdd] = useState('')
    

   const deleteHotel = (val2) => {
     const res = window.confirm("Are you sure To delete")
     if (res) {
        hotelArr.map((data)=>{
            if (data.id === val2){
                data.status=0
            }
            localStorage.setItem("hoteldata",JSON.stringify(hotelArr))
        })
     }
     navigate('/Showhotel')
   }
    
    const updateHotel = (val)=>{
      add = window.prompt('Enter Address to Update')
      // rate = window.prompt('Enter Rating to update')
      setAdd(add)
      // setRate(rate)

      hotelArr.map((data)=>{
        if(data.id===val){
            data.address = add
            // data.rating = rate
        }
        localStorage.setItem("hoteldata",JSON.stringify(hotelArr))
      })
       navigate('/Showhotel')
      console.log(`updated value of add : ${add} `)
        console.log ( `deleting ${val}`)
    }
    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h5 className="navbar-brand text-white">TAJ by TATA</h5>
        <Link to="/">
          <h5 className="navbar-brand text-white">Home</h5>
        </Link>
        <Link to="/AdminHome">
          <h5 className="navbar-brand text-white">Admin Dashboard</h5>
        </Link>
        <Link to="/BookingList">
          <h5 className="navbar-brand text-white">Bookings</h5>
        </Link>
        <Link to="/CanceledBookingList">
          <h5 className="navbar-brand text-white">Canceled Bookings</h5>
        </Link>
        <Link to="/UsersList">
          <h5 className="navbar-brand text-white">Users</h5>
        </Link>
        <Link to="/HotelMaster">
          <h6 className="navbar-brand text-white">Hotel Master</h6>
        </Link>

      </nav>
          <table className="table table-striped table-hover">
            <thead>
              <tr>
                <th>
                    #
                </th>
                <th>Id</th>
                <th>Name</th>
                <th>Address</th>
                <th>Rating</th>

                <th> Action</th>
              </tr>


            </thead>
            <tbody>
              {
                hotelArr && hotelArr.length>0 ?
                hotelArr.map((hotelData,index)=>{
                    if (hotelData.status===1){
                        return (
                            <tr>
                               <td> {index+1}</td> 
                               <td>{hotelData.id}</td>
                               <td>{hotelData.name}</td>
                               <td>{hotelData.address}</td>
                               <td>{hotelData.rating}</td>
                               <td><button className="btn btn-danger mx-2" onClick={()=>deleteHotel(hotelData.id)}>Delete</button>
                                <button className="btn btn-primary" onClick={()=>updateHotel(hotelData.id)}>Update</button></td>
                            </tr>
                        )
                    }
                }) : 'no data'
              }
            </tbody>
          </table>
        </div>
      );
    
}

export default Showhotel;
