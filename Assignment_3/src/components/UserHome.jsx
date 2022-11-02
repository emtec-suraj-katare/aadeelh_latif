import React from "react";
import { Link } from "react-router-dom";


const UserHome = () => {
  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h5 className="navbar-brand text-white">TAJ by TATA </h5>
        <Link to="/">
          <h5 className="navbar-brand text-white">Home </h5>
        </Link>
        <Link to="/HotelList">
          <h5 className="navbar-brand text-white">Hotel List </h5>
        </Link>
        {/* <Link to="/BookTable">
          <h5 className="navbar-brand text-white">Booking </h5>
        </Link> */}
        <Link to="/History">
          <h5 className="navbar-brand text-white">History</h5>
        </Link>
      </nav>

      <h1>User Side</h1>
    </div>
  );
};

export default UserHome;
