import React from "react";
import { useEffect } from "react";
import { useState } from "react";

import { Link } from "react-router-dom";

const History =()=>{
    const  [hisArr,setHisArr] = useState([])
  
    useEffect (()=>{
        const bookingArray = localStorage.getItem ("bookingArray")
        setHisArr (JSON.parse(bookingArray))
        
    },[])
   
    return(
        <div>
    <table className="table table-striped table-hover">
            <thead>
              <tr>
                <th>
                    #
                </th>
                <th>Id</th>
                <th>Name</th>
                <th>Table</th>
                
              </tr>


            </thead>
            <tbody>
              {
                hisArr && hisArr.length>0 ?
                hisArr.map((bookingArray,index)=>{
                    return (
                            <tr>
                               <td> {index+1}</td> 
                               <td>{bookingArray.uid}</td>
                               <td>{bookingArray.hname}</td>
                               <td>{bookingArray.table}</td>
                               
                              
                            </tr>
                        )
                }) : 'no data'
              }
            </tbody>
          </table>
        </div>
      );
    
}
export default History;