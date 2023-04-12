import styled from "styled-components";

export const Header = styled.header`
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  padding: 20px 100px 0 20px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  z-index: 99;
`;
export const NavBar = styled.nav`
  list-style: none;
  margin: 0;
  padding: 0;
  display: flex;

  a {
    margin-left: 30px;
    cursor: pointer;
  }

  &.navegacao a {
    position: relative;
    font-size: 1.1em;
    text-decoration: none;
    font-weight: 500;
    margin-left: 30px;
    cursor: pointer;
    flex-direction: flex-end;
    color: ${({ theme }) => theme.text};
  }

  &.navegacao button {
    margin-left: 30px;
  }
  &.navegacao a::after {
    content: "";
    position: absolute;
    width: 100%;
    left: 0;
    bottom: 1px;
    height: 3px;
    background-color: ${({ theme }) => theme.text};
    border-radius: 5px;
    transform-origin: right;
    transform: scaleX(0);
    transition: transform 0.5s;
  }

  &.navegacao a:hover::after {
    transform: scaleX(1);
    transform-origin: left;
    background-color: ${({ theme }) => theme.text};
  }
`;

export const ButtonDark = styled.button`
  border: none;
  width: 35px;
  height: 35px;
  transition: all ${({ theme }) => theme.transitionDelay},
    ${({ theme }) => theme.transitionCurve};
  background-color: transparent;
  border: none;
  cursor: pointer;
  font-size: 1.5rem;
  color: ${({ theme }) => theme.text};
`;
