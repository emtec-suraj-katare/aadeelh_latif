import React, { useState } from "react";

const Login = () => {
  function Show() {
    return (
      <div>
        {console.log(`email: ${email}`)}
        {console.log(`password: ${password}`)}
      </div>
    );
  }
  function SetEmail(e) {
    setEmail(e.target.value);
  }
  function SetPassWord(e) {
    setPassword(e.target.value);
  }
  const [email, setEmail] = useState();
  const [password, setPassword] = useState();
  return (
    <div className="a">
      <div className="a"><h1 align="center">Login Form</h1></div>
      <div className="formSetup a">
        <div className="b">
          <label htmlFor="exampleInputEmail1" className="form-label">
            Email address
          </label>
          <input
            onChange={SetEmail}
            type="email"
            className="form-control"
            id="exampleInputEmail1"
            aria-describedby="emailHelp"
          />
         </div>
        <div className="b">
          <label htmlFor="exampleInputPassword1" className="form-label">
            Password
          </label>
          <input
            onChange={SetPassWord}
            type="password"
            className="form-control"
            id="exampleInputPassword1"
          />
        </div>
        <div className="b form-check"></div>
        <button onClick={Show} type="button" className="btn btn-success">
          Login
        </button>
      </div>
    </div>
  );
};

export default Login;
