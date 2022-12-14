import React from "react";
import { Link } from "react-router-dom";

const AdminHome = () => {
  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h5 className="navbar-brand text-white">TAJ by TATA</h5>
        <Link to="/">
          <h5 className="navbar-brand text-white">Home</h5>
        </Link>
        <Link to="/HotelMaster">
          <h5 className="navbar-brand text-white">Add Hotel</h5>
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

      <div className="d-flex flex-row bd-highlight mb-3 ">
        <div className="col align-self-center ">
          <h1 align="center">Welcome To Admin Page!!!</h1>
        </div>
      </div>
    </div>
  );
};

export default AdminHome;
