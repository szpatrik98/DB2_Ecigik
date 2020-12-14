set serveroutput on;
declare 
    v_call_nev int;
    v_nev ecigik.nev%type := 'VAporesso GENes';
begin
v_call_nev := sf_check_nev(v_nev);
    
    IF v_call_sorszam = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi nev helyes: '||v_nev);
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Az alábbi nev helytelen: '||v_nev);    
    END IF;
END;