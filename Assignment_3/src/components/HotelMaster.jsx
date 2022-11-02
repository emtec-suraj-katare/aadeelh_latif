import React, { useState } from "react";
import { Link } from "react-router-dom";




const AddHotel = (props) => {

  const [Id, setId] = useState();
  const [Name, setName] = useState();
  const [Address, setAddress] = useState();
  const [Rating, setRating] = useState();
  // const [array, setArray] = useState([...props.hotelData]);

  const  addHotel=()=> {
    const object = {
        id : Id , 
        name : Name ,
        address : Address,
        rating : Rating ,
        status : 1
    }


    const hotelData = JSON.parse(localStorage.getItem("hoteldata") || " []")
    hotelData.push(object)
    localStorage.setItem("hoteldata",JSON.stringify(hotelData))
   
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
        <Link to="/Showhotel">
          <h5 className="navbar-brand text-white">Update </h5>
        </Link>
      </nav>

      <div className="inputBody m-5">
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Hotel ID </b>
            </label>
          </span>
          <input
            id="id"
            onChange={(e) => setId(e.target.value)}
            className="form-control"
            placeholder="Enter Hotel Id"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Hotel Name </b>
            </label>
          </span>
          <input
            id="id"
            onChange={(e) => setName(e.target.value)}
            className="form-control"
            placeholder="Enter Name"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Hotel Address</b>
            </label>
          </span>
          <input
            id="name"
            onChange={(e) => setAddress(e.target.value)}
            className="form-control"
            placeholder="Address"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Rating</b>
            </label>
          </span>
          <input
            id="rating"
            onChange={(e) => setRating(e.target.value)}
            className="form-control"
            placeholder="Rating"
            aria-label="With input"
          ></input>
        </div>
        <div className="successButton mt-3">
          <button onClick={addHotel} type="button" className="btn btn-success">
            SUBMIT
          </button>
        </div>
      </div>
      {/* <div className="m-3">{HotelTable}</div> */}
    </div>
  );
};

export default AddHotel;
