/* eslint-disable react/prop-types */
import React, { Fragment, useState } from "react";
import { Link } from "react-router-dom";
import GlobalTheme from "../../styles/globals.js";
import { ThemeProvider } from "styled-components";
import { ReactComponent as Logo } from "../../assets/svg/logo.svg";
import { lightTheme, darkTheme } from "../../utils/theme.js";
import { BsSun, BsMoonStars } from "react-icons/bs";
import { ButtonDark, Header, NavBar } from "./Topbar-styles.js";
import Login from "../Login/Login.jsx";

const Topbar = () => {
  const [theme, setTheme] = useState("light");
  const [isLogin, setIsLogin] = useState(false);

  function alternarTheme() {
    setTheme(theme === "light" ? "dark" : "light");
  }

  return (
    <ThemeProvider theme={theme === "light" ? lightTheme : darkTheme}>
      <Fragment>
        <GlobalTheme />
        <Header>
          <Link to="/">
            <Logo className="logo" alt={"Logo do nosso banco T&C BANKING"} />
          </Link>
          <NavBar className="navegacao">
            <Link to="/">Inicio</Link>
            <Link
              onClick={() => setIsLogin(true)}
              style={{ marginRight: "10px" }}
            >
              Login
            </Link>
            <Login isOpen={isLogin} setModalClose={() => setIsLogin(false)} />
            <ButtonDark className="theme-toggle" onClick={alternarTheme}>
              {theme === "light" ? <BsSun /> : <BsMoonStars />}
            </ButtonDark>
          </NavBar>
        </Header>
      </Fragment>
    </ThemeProvider>
  );
};

export default Topbar;
