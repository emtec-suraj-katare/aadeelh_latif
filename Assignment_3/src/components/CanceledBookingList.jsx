import React from "react";
import { Link } from "react-router-dom";

function CBDisplay(props) {
  return (
    <div>
      <table className="table table-striped table-hover">
        <thead>
          <tr>
            <td>User Id</td>
            <td>Hotel Id</td>
            <td>Hotel Name</td>
            <td>No_Of_Table</td>
          </tr>
        </thead>
        <tbody>
          {props.map((value) => {
            return (
              <tr>
                <td>{value.UId}</td>
                <td>{value.Id}</td>
                <td>{value.Name}</td>
                <td>{value.No_Of_Table}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
}
const CanceledBookingList = (props) => {
  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h6 className="navbar-brand text-white">TAJ by TATA</h6>
        <Link to="/">
          <h6 className="navbar-brand text-white">Home</h6>
        </Link>
        <Link to="/AdminHome">
          <h6 className="navbar-brand text-white">Admin Dashboard</h6>
        </Link>
        <Link to="/HotelMaster">
          <h6 className="navbar-brand text-white">Hotel Master</h6>
        </Link>
        <Link to="/BookingList">
          <h6 className="navbar-brand text-white">Bookings</h6>
        </Link>
        <Link to="/UsersList">
          <h6 className="navbar-brand text-white">Users</h6>
        </Link>
      </nav>

      <div align="center" className="m-5">
        <h1>Canceled Booking List</h1>
      </div>
      <div>
        {CBDisplay(props.canceledbookingData)}
        <hr></hr>
      </div>
    </div>
  );
};

export default CanceledBookingList;
