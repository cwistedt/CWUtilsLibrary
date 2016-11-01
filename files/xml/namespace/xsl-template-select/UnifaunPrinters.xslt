<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" 
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:t="com.unifaun.orderengine.config.userdata"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
                xmlns:ufb="http://www.unifaun.com/ufo/bean"
                exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/t:*">


      <root>

        <printers>
          <xsl:for-each select="t:Logins/t:Object">         
            <xsl:variable name="printers" select="t:Printers/t:Printers/t:Object" />
            <xsl:for-each select="t:Printers/t:PrinterMap/t:ObjectEntry/t:Key">
              <xsl:variable name="key" select="current()" />
              <xsl:for-each select="$printers">
                <xsl:if test="current()/t:Name = $key">

                  <xsl:variable name="media" select="./t:Media"/>
                  <xsl:variable name="system" select="current()/../../../t:Login/t:System"/>
                  <printer>
                    <name>
                      <xsl:value-of select="$key"/>
                    </name>
                    <account>
                      <xsl:choose>
                        <xsl:when test="$system = 'PSONLINE2'">Pacsoft</xsl:when>
                        <xsl:when test="$system = 'UFONLINE2'">Unifaun</xsl:when>
                        <xsl:otherwise>Unknown</xsl:otherwise>
                      </xsl:choose>
                    </account>
                    <size>
                      <xsl:choose>
                        <xsl:when test="$media = 'thermo-72'">107x72</xsl:when>
                        <xsl:when test="$media = 'thermo-250'">107x250</xsl:when>
                        <xsl:otherwise>Unknown</xsl:otherwise>
                      </xsl:choose>
                    </size>
                  </printer>
                
                </xsl:if>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
        </printers>

      </root>
    </xsl:template>
</xsl:stylesheet>
