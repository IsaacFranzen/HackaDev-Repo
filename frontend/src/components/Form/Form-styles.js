import styled from "styled-components";

export const TabsDiv = styled.div`
  width: 60%;
  margin: 3.5rem auto 1.5rem;
  padding: 2rem 1rem;
  border-radius: 2rem;
  @media (max-width: 769px) {
    padding: 2rem 0;
  }
`;

export const DivButtonStyles = styled.div`
  width: 100%;
  justify-content: center;
  display: flex;
  margin-top: 40px;
`;

export const StyleButton = styled.button`
  width: 100px;
  height: 50px;
  justify-content: space-between;
  margin: 10px;
  font-weight: bold;
  color: white;
  box-shadow: 0 10px 10px 0 #a972d3;
  background-color: #a972d3;
  border-radius: 10px;
  &:hover {
    background-color: #7920be;
  }
`;

export const DivNav = styled.ul`
  margin: 0 1rem auto 2rem;
  display: flex;
  justify-content: center;
  align-items: center;

  @media (max-width: 768px) {
    display: none;
    width: 90%;
  }
  li {
    padding: 1rem;
    width: 100%;
    list-style: none;
    text-align: center;
    display: flex;
    align-items: center;
    border-radius: 0.5rem;
    font-weight: bold;
    cursor: pointer;
    transition: all 0.7s;
    flex-direction: column;
    &:hover {
      background: rgba(172, 107, 221, 0.35);
    }
    &.active {
      color: #fff;
      background: #791ebe;
    }
  }
`;
