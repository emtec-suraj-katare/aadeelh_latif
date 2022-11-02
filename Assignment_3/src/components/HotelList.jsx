import React from "react";
import { useEffect } from "react";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";

const HotelList =()=>{

  // const [hotelName ,setHotelName] = useState('')
  // const [customer ,setCustomer] = useState('')
  // const [table ,setTable] = useState('')
    const  [hotelArr,setArr] = useState([])
    
    useEffect (()=>{
        const hotelData = localStorage.getItem ("hoteldata")
        setArr (JSON.parse(hotelData))
        
    },[])
    
    const navigate = useNavigate()
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
      navigate('/HotelList')
    }

    const booking = (val3) => {
      
      localStorage.setItem("bookingId",val3)
      navigate ('/BookHotel')
    }
  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h5 className="navbar-brand text-white">TAJ by TATA </h5>
        <Link to="/">
          <h5 className="navbar-brand text-white">Home </h5>
        </Link>
        <Link to="/UserHome">
          <h5 className="navbar-brand text-white">User Home </h5>
        </Link>
        {/* <Link to="/BookTable">
          <h5 className="navbar-brand text-white">Booking </h5>
        </Link> */}
        <Link to="/History">
          <h5 className="navbar-brand text-white">History </h5>
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
                               <td><button className="btn btn-primary mx-2" onClick={()=>booking(hotelData.id)}>Booking</button>
                                <button className="btn btn-danger" onClick={()=>deleteHotel(hotelData.id)}>Cancel</button></td>
                            </tr>
                        )
                    }
                }) : 'no data'
              }
            </tbody>
          </table>
        </div>
  );
};

export default HotelList;
