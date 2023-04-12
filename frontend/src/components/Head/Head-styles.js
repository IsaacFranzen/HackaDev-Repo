import styled from "styled-components";

export const Container = styled.div`
  width: 100%;
  height: 97vh;
  display: flex;
  flex-direction: column;
  padding-top: 5%;
  font-style: normal;

  @media (max-width: 768px) {
    margin-top: 15%;
    display: flex;
    text-align: center;
  }
`;

export const Main = styled.main`
  display: flex;
  justify-content: center;
  align-items: center;
  margin: auto;
  h1 {
    font-size: 49px;
    line-height: 56px;
    font-weight: normal;
    color: ${({ theme }) => theme.text};
    max-width: 489px;

    span {
      color: #7920be;
    }
  }
`;

export const Sections = styled.section`
  p {
    font-size: 14px;
    line-height: 28px;
    color: ${({ theme }) => theme.text};
    max-width: 428px;
    margin: 40px 0;

    span {
      font-weight: bold;
    }
  }
`;

export const Button = styled.button`
  color: #f9f9f9;
  width: 222px;
  height: 56px;
  background: #7920be;
  border-radius: 4px;
  border: none;
  font-weight: bold;
  cursor: pointer;

  &:hover {
    transition: 0.3s;
    cursor: pointer;
    width: 244px;
    height: 66px;
  }
`;

export const DivImage = styled.div`
  @media (max-width: 768px) {
    display: none;
  }
`;
